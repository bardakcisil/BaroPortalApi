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
        public ResponseCalculationDto AttorneyFeeCalculate(CalculationDto calcDto)
        {
            ResponseCalculationDto response = new ResponseCalculationDto();




            if (calcDto.Status == "İcra Takipleri İçin")
            {
               
                response.total = CalcFee1(calcDto.Amount);
                response.HasError = false;
                response.Message = "success";
            }
            else if (calcDto.Status == "Konusu Para Olan Davalar İçin")
            {
                switch (calcDto.Case)
                {
                    case "İcra Mahkemeleri":
                       
                        response.total = CalcFee(calcDto.Amount);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    case "Sulh Hukuk Mahkemeleri":
                      
                        response.total = CalcFee(calcDto.Amount);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    case "Sulh Ceza/İnfaz Hakimlikleri":
                       
                        response.total = CalcFee(calcDto.Amount);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    case "Asliye Mahkemeleri":
                       
                        response.total = CalcFee(calcDto.Amount);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    case "Tüketici Mahkemeleri":
                        
                        response.total = CalcFee(calcDto.Amount);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    case "Fikri ve Sınai Haklar Mahkemeleri":
                       
                        response.total = CalcFee(calcDto.Amount);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    case "İdare ve Vergi Mahkemeleri - Duruşmalı":
                       
                        response.total = CalcFee(calcDto.Amount);
                        response.HasError = false;
                        response.Message = "success";
                        break;
                    case "İdare ve Vergi Mahkemeleri - Duruşmasız":
                       
                        response.total = CalcFee(calcDto.Amount);
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
        public double? CalcFee1(double? amount)
        {
            switch (amount)
            {
                case 40000:
                    fee = ((amount * 15) / 100) + (amount);
                    break;
                case > 0 and < 50000:
                    fee = ((amount * 13) / 100) + (amount);
                    break;
                case > 50000 and <= 90000:
                    fee = ((amount * 14) / 100) + (amount);
                    break;
                case > 90000 and <= 250000:
                    fee = ((amount * 9.50) / 100) + (amount);
                    break;
                case > 250000 and <= 620000:
                    fee = ((amount * 7) / 100) + (amount);
                    break;
                case > 620000 and <= 775000:
                    fee = ((amount * 5) / 100) + (amount);
                    break;
                case > 775000 and <= 12750000:
                    fee = ((amount * 3) / 100) + (amount);
                    break;
                case > 1275000 and <= 100000000:
                    fee = ((amount * 1.80) / 100) + (amount);
                    break;
                case > 100000000 :
                    fee = ((amount * 1) / 100) + (amount);
                    break;
                default:

                    break;
            }
            return fee;
        }
        public double? CalcFee(double? amount)
        {
            switch (amount)
            {
                case 100000:
                    fee = ((amount * 16) / 100) + (amount);
                    break;
                case > 0 and < 100000:
                    fee = ((amount * 15) / 100) + (amount);
                    break;
                case > 100000 and <= 300000:
                   fee = ((amount * 14) / 100) + (amount);
                    break;
                case > 300000 and <= 500000:
                    fee = ((amount * 11) / 100) + (amount);                 
                    break;
                case > 500000 and <= 700000:
                    fee = ((amount * 8) / 100) + (amount);
                    break;
                case > 700000 and <= 900000:
                    fee = ((amount * 5) / 100) + (amount);
                    break;
                case > 900000 and <= 1100000:
                    fee = ((amount * 3) / 100) + (amount);
                    break;
                case > 1100000 and <= 1300000:
                    fee = ((amount * 2) / 100) + (amount);
                    break;
                case > 1300000 and <= 5000000:
                    fee = ((amount * 1) / 100) + (amount);                    
                   break;
                default:
                    
                    break;
            }
            return fee;
        }

        public ResponseCalculationDto LivingFeeCalculate(CalculationDto calcDto)
        {
            ResponseCalculationDto response = new ResponseCalculationDto();




            if (calcDto.Status == "Bekar")
            {
                
                response.total = 25;
                response.HasError = false;
                response.Message = "success";
            }
            else if (calcDto.Status == "Evli" || calcDto.Case == "Çalışmıyor" || calcDto.Amount == 0)
            {
                response.total = 0.0;
             
                response.HasError = false;
                response.Message = "success";
            }
            else if (calcDto.Status == "Evli" ||  calcDto.Case == "Çalışıyor" || calcDto.Amount == 1)
            {
                response.total = 50;
             
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
