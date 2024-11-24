using Data.DTO;
using Data.Models;
using Service.AdmissionInformationSer;
using Service.StudentProfileServ;

namespace ARMS_API.ValidData
{
    public class ValidAdmissionTime
    {
        private UserInput _userInput;
        private IAdmissionInformationService _admissionInformationService;
        public ValidAdmissionTime(UserInput userInput, IAdmissionInformationService admissionInformationService)
        {
            _userInput = userInput;
            _admissionInformationService = admissionInformationService;
        }

        internal void ValidDataAdmissionTime(object year, DateTime startAdmission, DateTime endAdmission, DateTime startRegister, DateTime endRegister, string admissionInformationName)
        {
            throw new NotImplementedException();
        }
        internal void ValidateAdmissionTimes(AdmissionInformation_Add_DTO admissionInformationDTO)
        {
            try
            {
                AdmissionTime_Add_DTO previousAdmissionTime = null;
                AdmissionTime_Add_DTO nextAdmissionTime = null;
                if (admissionInformationDTO.AdmissionTimes != null && admissionInformationDTO.AdmissionTimes.Any())
                {
                    foreach (var admissionTime in admissionInformationDTO.AdmissionTimes)
                    {
                        // Kiểm tra xem thời gian của AdmissionTime có nằm trong khoảng thời gian của AdmissionInformation không
                        if (admissionTime.StartRegister < admissionInformationDTO.StartAdmission || admissionTime.StartRegister > admissionInformationDTO.EndAdmission)
                        {
                            throw new Exception($"Thời gian bắt đầu đăng ký của {admissionTime.AdmissionInformationName} không nằm trong khoảng thời gian tuyển sinh.");
                        }

                        if (admissionTime.EndRegister < admissionInformationDTO.StartAdmission || admissionTime.EndRegister > admissionInformationDTO.EndAdmission)
                        {
                            throw new Exception($"Thời gian kết thúc đăng ký của {admissionTime.AdmissionInformationName} không nằm trong khoảng thời gian tuyển sinh.");
                        }

                        if (admissionTime.StartAdmission < admissionInformationDTO.StartAdmission || admissionTime.StartAdmission > admissionInformationDTO.EndAdmission)
                        {
                            throw new Exception($"Thời gian bắt đầu tuyển sinh của {admissionTime.AdmissionInformationName} không nằm trong khoảng thời gian tuyển sinh.");
                        }

                        if (admissionTime.EndAdmission < admissionInformationDTO.StartAdmission || admissionTime.EndAdmission > admissionInformationDTO.EndAdmission)
                        {
                            throw new Exception($"Thời gian kết thúc tuyển sinh của {admissionTime.AdmissionInformationName} không nằm trong khoảng thời gian tuyển sinh.");
                        }

                        // Kiểm tra nếu thời gian bắt đầu lớn hơn kết thúc cho từng thời gian của AdmissionTime
                        if (admissionTime.StartRegister >= admissionTime.EndRegister)
                        {
                            throw new Exception($"Thời gian bắt đầu đăng ký của {admissionTime.AdmissionInformationName} phải nhỏ hơn thời gian kết thúc đăng ký.");
                        }

                        if (admissionTime.StartAdmission >= admissionTime.EndAdmission)
                        {
                            throw new Exception($"Thời gian bắt đầu tuyển sinh của {admissionTime.AdmissionInformationName} phải nhỏ hơn thời gian kết thúc tuyển sinh.");
                        }
                        foreach (var at in admissionInformationDTO.AdmissionTimes.OrderBy(a => a.StartAdmission))  // Sắp xếp theo StartAdmission
                        {
                            // Kiểm tra xem nếu đợt tuyển sinh hiện tại là đợt trước hay đợt sau đợt mới
                            if (previousAdmissionTime != null && nextAdmissionTime == null && at.StartAdmission > previousAdmissionTime.StartAdmission)
                            {
                                nextAdmissionTime = at;
                            }

                            // Kiểm tra với đợt tuyển sinh trước đó
                            if (previousAdmissionTime != null)
                            {
                                // Kiểm tra thời gian của đợt mới với đợt trước
                                if (at.StartRegister < previousAdmissionTime.EndRegister || at.EndRegister > previousAdmissionTime.StartRegister)
                                {
                                    throw new Exception($"Thời gian đăng ký của đợt {at.AdmissionInformationName} không hợp lệ với đợt tuyển sinh trước.");
                                }

                                if (at.StartAdmission < previousAdmissionTime.EndAdmission || at.EndAdmission > previousAdmissionTime.StartAdmission)
                                {
                                    throw new Exception($"Thời gian tuyển sinh của đợt {at.AdmissionInformationName} không hợp lệ với đợt tuyển sinh trước.");
                                }
                            }

                            // Kiểm tra với đợt tuyển sinh sau đó
                            if (nextAdmissionTime != null)
                            {
                                // Kiểm tra thời gian của đợt mới với đợt sau
                                if (at.StartRegister >= nextAdmissionTime.EndRegister || at.EndRegister <= nextAdmissionTime.StartRegister)
                                {
                                    throw new Exception($"Thời gian đăng ký của đợt {at.AdmissionInformationName} không hợp lệ với đợt tuyển sinh sau.");
                                }

                                if (at.StartAdmission >= nextAdmissionTime.EndAdmission || at.EndAdmission <= nextAdmissionTime.StartAdmission)
                                {
                                    throw new Exception($"Thời gian tuyển sinh của đợt {at.AdmissionInformationName} không hợp lệ với đợt tuyển sinh sau.");
                                }
                            }

                            previousAdmissionTime = at;
                        }
                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal async Task ValidDataAdmissionTime(AdmissionTime_Add_DTO admissionTimeDTO)
        {
            AdmissionTime previousAdmissionTime = null;
            AdmissionTime nextAdmissionTime = null;

            // Lấy thông tin tuyển sinh từ dịch vụ
            AdmissionInformation admissionInformation = await _admissionInformationService.GetAdmissionInformationById(admissionTimeDTO.AIId);

            // Sắp xếp các AdmissionTimes theo StartAdmission
            foreach (var at in admissionInformation.AdmissionTimes.OrderBy(a => a.StartAdmission))
            {
                // Kiểm tra với đợt tuyển sinh trước đó
                if (previousAdmissionTime != null)
                {
                    // Kiểm tra thời gian đăng ký của đợt mới với đợt trước
                    if (admissionTimeDTO.StartRegister < previousAdmissionTime.EndRegister || admissionTimeDTO.EndRegister > previousAdmissionTime.StartRegister)
                    {
                        throw new Exception($"Thời gian đăng ký của đợt {admissionTimeDTO.AdmissionInformationName} không hợp lệ với đợt tuyển sinh trước.");
                    }

                    // Kiểm tra thời gian tuyển sinh của đợt mới với đợt trước
                    if (admissionTimeDTO.StartAdmission < previousAdmissionTime.EndAdmission || admissionTimeDTO.EndAdmission > previousAdmissionTime.StartAdmission)
                    {
                        throw new Exception($"Thời gian tuyển sinh của đợt {admissionTimeDTO.AdmissionInformationName} không hợp lệ với đợt tuyển sinh trước.");
                    }
                }

                // Kiểm tra với đợt tuyển sinh sau đó
                if (nextAdmissionTime != null)
                {
                    // Kiểm tra thời gian đăng ký của đợt mới với đợt sau
                    if (admissionTimeDTO.StartRegister >= nextAdmissionTime.EndRegister || admissionTimeDTO.EndRegister <= nextAdmissionTime.StartRegister)
                    {
                        throw new Exception($"Thời gian đăng ký của đợt {admissionTimeDTO.AdmissionInformationName} không hợp lệ với đợt tuyển sinh sau.");
                    }

                    // Kiểm tra thời gian tuyển sinh của đợt mới với đợt sau
                    if (admissionTimeDTO.StartAdmission >= nextAdmissionTime.EndAdmission || admissionTimeDTO.EndAdmission <= nextAdmissionTime.StartAdmission)
                    {
                        throw new Exception($"Thời gian tuyển sinh của đợt {admissionTimeDTO.AdmissionInformationName} không hợp lệ với đợt tuyển sinh sau.");
                    }
                }

                // Cập nhật previousAdmissionTime và nextAdmissionTime
                previousAdmissionTime = at;
                nextAdmissionTime = null;

                // Kiểm tra nếu đợt hiện tại có thời gian bắt đầu sau thời gian kết thúc của đợt trước
                if (previousAdmissionTime != null && at.StartAdmission > previousAdmissionTime.StartAdmission)
                {
                    nextAdmissionTime = at;
                }
            }
        }

    }
}
