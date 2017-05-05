using QLTB.DAL;
using QLTB.DAL.Data;
using QLTB.Model;
using QLTB.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Handler
{
    public class DbThongTinDVHandler
    {
        public ThongTinDonViModel Get()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<ThongTinDonVi>().GetAll().FirstOrDefault();
                    if (data != null)
                    {
                        return MyConvert.ConvertSameData<ThongTinDonViModel>(data);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public ThongTinDonViModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork= new UnitOfWork())
                {
                    var data=unitOfWork.GetRepository<ThongTinDonVi>().GetById(Id);
                    if (data != null)
                    {
                        return MyConvert.ConvertSameData<ThongTinDonViModel>(data);
                    }
                    return null;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public int Create(ThongTinDonViModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data= MyConvert.ConvertSameData<ThongTinDonVi>(model);
                    unitOfWork.GetRepository<ThongTinDonVi>().Add(data);
                    if (unitOfWork.Save() >= 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int Update(ThongTinDonViModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    
                    var data=unitOfWork.GetRepository<ThongTinDonVi>().GetById(model.MaDonVi);
                    MyConvert.TransferValues(data, model);
                    unitOfWork.GetRepository<ThongTinDonVi>().Update(data);
                    if (unitOfWork.Save() >= 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        private string GenerateCode()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    string newCode = "";
                    var last = unitOfWork.GetRepository<ThongTinDonVi>().GetAll().OrderByDescending(p => p.MaDonVi).FirstOrDefault();
                    if (last != null)
                    {
                        var lastCode = last.MaDonVi;
                        var numberPart = lastCode.Substring(lastCode.LastIndexOf('.') + 1);
                        var prefixPart = lastCode.Remove(lastCode.LastIndexOf('.'));
                        var number = Convert.ToInt32(numberPart.TrimStart('0'));
                        var suffix = number + 1;
                        int sizePrefix = prefixPart.Length;
                        int sizeSuffix = suffix.ToString().Length;
                        string middle = "";
                        for(int i = 0; i < (10 - sizePrefix - sizeSuffix); i++)
                        {
                            middle += "0";
                        }
                        newCode = prefixPart + middle + suffix;
                        return newCode;
                    }
                    else
                    {
                        newCode = "DVGD000001";
                    }
                    return newCode;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
