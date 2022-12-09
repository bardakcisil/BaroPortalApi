using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Concrete
{
    public class CalculationService : ICalculationService
    {
        public ResponseCalculationDto AttorneyFeeCalculate(LivingFeeCalculationDto calcDto)
        {
            ResponseCalculationDto response = new ResponseCalculationDto();




            if (calcDto.Status == "İcra Takipleri için")
            {
                response.bill = CalcFee(calcDto.children);
                response.total = CalcFee(calcDto.children);
                response.HasError = false;
                response.Message = "success";
            }
            else if (calcDto.Status == "Konusu Para Olan Davalar için")
            {
                switch (calcDto.partnerWork)
                {
                    case "İcra Mahkemeleri":
                        response.bill = CalcFee(calcDto.children);
                        response.total = CalcFee(calcDto.children);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    case "Sulh Hukuk Mahkemeleri":
                        response.bill = CalcFee(calcDto.children);
                        response.total = CalcFee(calcDto.children);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    case "Sulh Ceza/İnfaz Hakimlikleri":
                        response.bill = CalcFee(calcDto.children);
                        response.total = CalcFee(calcDto.children);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    case "Asliye Mahkemeleri":
                        response.bill = CalcFee(calcDto.children);
                        response.total = CalcFee(calcDto.children);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    case "Tüketici Mahkemeleri":
                        response.bill = ((calcDto.children * 8) / 100) + (calcDto.children);
                        response.total = ((calcDto.children * 8) / 100) + (calcDto.children);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    case "Fikri ve Sınai Haklar Mahkemeleri":
                        response.bill = ((calcDto.children * 5) / 100) + (calcDto.children);
                        response.total = ((calcDto.children * 5) / 100) + (calcDto.children);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    case "İdare ve Vergi Mahkemeleri - Duruşmalı":
                        response.bill = ((calcDto.children * 3) / 100) + (calcDto.children);
                        response.total = ((calcDto.children * 3) / 100) + (calcDto.children);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    case "İdare ve Vergi Mahkemeleri - Duruşmasız":
                        response.bill = ((calcDto.children * 2) / 100) + (calcDto.children);
                        response.total = ((calcDto.children * 2) / 100) + (calcDto.children);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    default:
                        response.HasError = true;
                        response.Message = "Not Found";
                        break;
                }

            }



            return response;
        }
        double? fee = 0;
        public double? CalcFee(double? amount)
        {
            switch (amount)
            {
                case 1000:
                    fee = ((amount * 16) / 100) + (amount);
                    break;
                case > 0 and < 1000:
                    fee = ((amount * 15) / 100) + (amount);
                    break;
                case > 1000 and <= 3000:
                   fee = ((amount * 14) / 100) + (amount);
                    break;
                case > 3000 and <= 5000:
                    fee = ((amount * 11) / 100) + (amount);                 
                    break;
                case > 5000 and <= 7000:
                    fee = ((amount * 8) / 100) + (amount);
                    break;
                case > 7000 and <= 9000:
                    fee = ((amount * 5) / 100) + (amount);
                    break;
                case > 9000 and <= 11000:
                    fee = ((amount * 3) / 100) + (amount);
                    break;
                case > 11000 and <= 13000:
                    fee = ((amount * 2) / 100) + (amount);
                    break;
                case > 13000 and <= 50000:
                    fee = ((amount * 1) / 100) + (amount);                    
                   break;
                default:
                    
                    break;
            }
            return fee;
        }

        public ResponseCalculationDto LivingFeeCalculate(LivingFeeCalculationDto calcDto)
        {
            ResponseCalculationDto response = new ResponseCalculationDto();




            if (calcDto.Status == "Bekar")
            {
                response.bill = 15;
                response.total = 25;
                response.HasError = false;
                response.Message = "success";
            }
            else if (calcDto.Status == "Evli" || calcDto.partnerWork == "Çalışmıyor" || calcDto.children == 0)
            {
                response.total = 0.0;
                response.bill = 10.0;
                response.HasError = false;
                response.Message = "success";
            }
            else if (calcDto.Status == "Evli" ||  calcDto.partnerWork == "Çalışıyor" || calcDto.children == 1)
            {
                response.total = 50;
                response.bill = 80;
                response.HasError = false;
                response.Message = "success";
            }
            
            else
            {
                response.HasError=true;
                response.Message = "Not Found";
            }



            return response;
        }

    }
}
