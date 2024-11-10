﻿using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PayFeeAdmissionRepository
    {
        private readonly ArmsDbContext _context;
        public PayFeeAdmissionRepository(ArmsDbContext context) { _context = context; }

        public async Task<List<PayFeeAdmission>> GetPayFeeAdmissions(string campusId)
        {
            try
            {
                List<PayFeeAdmission> PayFeeAdmissions = await _context.PayFeeAdmissions
                    .ToListAsync();
                return PayFeeAdmissions;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task AddNewPayFeeAdmission(PayFeeAdmission payFeeAdmission)
        {
            try
            {
                await _context.PayFeeAdmissions.AddAsync(payFeeAdmission);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Tạo mới hóa đơn không thành công");
            }
        }
    }
}
