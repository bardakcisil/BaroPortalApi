using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.Calculation;
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




            if (calcDto.Status == "Icra")
            {
               
                response.total = CalcFee1(calcDto.Amount);
                response.HasError = false;
                response.Message = "success";
            }
            else if (calcDto.Status == "Konusu")
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
                
                response.total = AGUH_Child(calcDto.Amount,50);
                response.HasError = false;
                response.Message = "success";
            }
            else if (calcDto.Status == "Evli" || calcDto.Case == "Çalışmıyor")
            {
                response.total = AGUH_Child(calcDto.Amount,60); 
             
                response.HasError = false;
                response.Message = "success";
            }
            else if (calcDto.Status == "Evli" ||  calcDto.Case == "Çalışıyor" )
            {
                response.total =  AGUH_Child(calcDto.Amount,50); 
             
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
        double? tot = 0;
        public double? AGUH_Child(double? amount,double? discount)
        {
            switch (amount)
            {
                case 0:
                    tot = 0 + discount;

                    break;
                case 1:
                    tot = 7.5 + discount;
                    break;
                case 2:
                    tot = 15 + discount;
                    break;
                case 3:
                    tot = 25 + discount;
                    break;
                case 4:
                    tot = 30 + discount;
                    break;
                case >5:
                    tot = 35 + discount;
                    break;
                default:

                    break;
            }
            return tot;
        }

        public SMMHResultDto ReceiptCalculate(SMMH calcDto)
        {
            SMMHResultDto response = new SMMHResultDto();

            double? Fon = (calcDto.Fon);  
            double? KDV =  (calcDto.Kdv );
            double? Stopaj = (calcDto.Stopaj);
            double? Tevkifat = (calcDto.Tevkifat);
            double? NetKdv = (calcDto.Kdv - calcDto.Kdv * Tevkifat);

           

            if(calcDto.Tur == "Brüt Tutar")
            {
                double? BrutTutar = calcDto.Amount;
                double? NetTutar = 0;
                double? KDVliTutar = NetTutar + KDV;
                if (Stopaj == 0)
                {
                    Fon = 0;
                    if (Tevkifat == 0)
                    {
                        NetTutar = BrutTutar;
                        KDVliTutar = NetTutar + KDV;
                    }
                    else if (Tevkifat > 0)
                    {
                        NetTutar = BrutTutar;
                        KDVliTutar = NetTutar + (calcDto.Kdv - calcDto.Kdv * Tevkifat/100);
                    }

                    else
                    {
                        response.HasError = true;
                        response.Message = "Not Found";
                    }
                }
                else if (Stopaj > 0)
                {
                    if (Fon == 0 && Tevkifat == 0)
                    {
                        NetTutar = BrutTutar - BrutTutar * Stopaj/100;
                        KDVliTutar = NetTutar + KDV;
                    }
                    else if (Fon > 0 && Tevkifat == 0)
                    {
                        NetTutar = BrutTutar - BrutTutar * Stopaj/100 - calcDto.Stopaj * Fon/100;
                        KDVliTutar = NetTutar + KDV;
                    }
                    else if (Fon == 0 && Tevkifat > 0)
                    {
                        NetTutar = BrutTutar - BrutTutar * Stopaj/100;
                        KDVliTutar = NetTutar + NetKdv;
                        Tevkifat = Tevkifat * 10;
                    }
                    else if (Fon > 0 && Tevkifat > 0)
                    {
                        NetTutar = BrutTutar - BrutTutar * Stopaj/100 - calcDto.Stopaj * Fon/100;
                        KDVliTutar = NetTutar + NetKdv;
                        Tevkifat = Tevkifat * 10;
                    
                    }
                    else
                    {
                        response.HasError = true;
                        response.Message = "Not Found";
                    }
                }

                calcDto.BrutTutar = BrutTutar;
                calcDto.NetTutar = NetTutar;
                calcDto.NetKdv = NetKdv;
                calcDto.KDVliTutar = KDVliTutar;
                calcDto.Tevkifat = Tevkifat;

                response.Tur = calcDto.Tur;
                response.BrutTutar = calcDto.BrutTutar;
                response.Stopaj = calcDto.Stopaj;
                response.Fon = calcDto.Fon;
                response.NetTutar = calcDto.NetTutar;
                response.Kdv = calcDto.Kdv;
                response.Tevkifat = calcDto.Tevkifat;
                response.NetKdv = calcDto.NetKdv;
                response.KdvliTutar = calcDto.KDVliTutar;
                response.HasError = false;
                response.Message = "success";
            }
            else if(calcDto.Tur == "Net Tutar")
            {
                double? BrutTutar = 0;
                double? NetTutar = calcDto.Amount;
                double? KDVliTutar = NetTutar + KDV;
                if (Stopaj == 0)
                {
                    Fon = 0;
                    if (Tevkifat == 0)
                    {
                        KDVliTutar = NetTutar + KDV;
                        BrutTutar = NetTutar;
                        Tevkifat = Tevkifat * 10;

                    }
                    else if (Tevkifat > 0)
                    {
                        
                        KDVliTutar = NetTutar + (calcDto.Kdv - calcDto.Kdv * Tevkifat/100);
                        BrutTutar = NetTutar;
                        Tevkifat = Tevkifat * 10;
                    }

                    else
                    {
                        response.HasError = true;
                        response.Message = "Not Found";
                    }
                }
                else if (Stopaj > 0)
                {
                    if (Fon == 0 && Tevkifat == 0)
                    {
                       
                        BrutTutar = NetTutar-NetTutar/(1-Stopaj);
                        KDVliTutar = NetTutar + KDV;
                    }
                    else if (Fon > 0 && Tevkifat == 0)
                    {
                       
                        BrutTutar = NetTutar - (NetTutar + (calcDto.Stopaj*Fon/100))/(1-Stopaj);   
                        KDVliTutar = NetTutar + KDV;
                    }
                    else if (Fon == 0 && Tevkifat > 0)
                    {
                        BrutTutar = NetTutar - NetTutar / (1 - Stopaj);
                        KDVliTutar = NetTutar + NetKdv;
                        Tevkifat = Tevkifat * 10;
                    }
                    else if (Fon > 0 && Tevkifat > 0)
                    {
                        BrutTutar = NetTutar-(NetTutar + (calcDto.Stopaj * Fon/100)) / (1 - Stopaj);
                        KDVliTutar = NetTutar + NetKdv;
                        Tevkifat = Tevkifat * 10;
                    }
                    else
                    {
                        response.HasError = true;
                        response.Message = "Not Found";
                    }
                }
                calcDto.BrutTutar = BrutTutar;
                calcDto.NetTutar = NetTutar;
                calcDto.NetKdv = NetKdv;
                calcDto.KDVliTutar = KDVliTutar;
                calcDto.Tevkifat = Tevkifat;

                response.Tur = calcDto.Tur;
                response.BrutTutar = calcDto.BrutTutar;
                response.Stopaj = calcDto.Stopaj;
                response.Fon = calcDto.Fon;
                response.NetTutar = calcDto.NetTutar;
                response.Kdv = calcDto.Kdv;
                response.Tevkifat = calcDto.Tevkifat;
                response.NetKdv = calcDto.NetKdv;
                response.KdvliTutar = calcDto.KDVliTutar;
                response.HasError = false;
                response.Message = "success";
            }
            else if (calcDto.Tur == "KDV Dahil Tahsil Edilecek Tutar")
            {
                double? BrutTutar = 0;
                
                double? KDVliTutar = calcDto.Amount;
                double? NetTutar = calcDto.Amount-KDV+KDVliTutar;
                if (Stopaj == 0)
                {
                    Fon = 0;
                    if (Tevkifat == 0)
                    {
                       
                       
                        NetTutar = KDVliTutar - KDV;
                        BrutTutar = NetTutar;
                    }
                    else if (Tevkifat > 0)
                    {
                       
                        
                        NetTutar = KDVliTutar - (calcDto.Kdv - calcDto.Kdv * Tevkifat/100);
                        BrutTutar = NetTutar;
                        Tevkifat = Tevkifat * 10;
                    }

                    else
                    {
                        response.HasError = true;
                        response.Message = "Not Found";
                    }
                }
                else if (Stopaj > 0)
                {
                    if (Fon == 0 && Tevkifat == 0)
                    {
                        NetTutar = KDVliTutar - KDV;
                        BrutTutar = NetTutar - NetTutar / (1 - Stopaj);

                    }
                    else if (Fon > 0 && Tevkifat == 0)
                    {
                        NetTutar = KDVliTutar - KDV;
                        BrutTutar = NetTutar - (NetTutar + (calcDto.Stopaj * Fon/100)) / (1 - Stopaj);
                      
                    }
                    else if (Fon == 0 && Tevkifat > 0)
                    {
                        NetTutar = KDVliTutar - NetKdv;
                        BrutTutar = NetTutar - NetTutar / (1 - Stopaj);
                        Tevkifat = Tevkifat * 10;

                    }
                    else if (Fon > 0 && Tevkifat > 0)
                    {
                        NetTutar = KDVliTutar - NetKdv;
                        BrutTutar = NetTutar - (NetTutar + (calcDto.Stopaj * Fon/100)) / (1 - Stopaj);
                        Tevkifat = Tevkifat * 10;

                    }
                    else
                    {
                        response.HasError = true;
                        response.Message = "Not Found";
                    }
                }

                calcDto.BrutTutar = BrutTutar;
                calcDto.NetTutar = NetTutar;
                calcDto.NetKdv = NetKdv;
                calcDto.KDVliTutar = KDVliTutar;
                calcDto.Tevkifat = Tevkifat;

                response.Tur = calcDto.Tur;
                response.BrutTutar = calcDto.BrutTutar;
                response.Stopaj = calcDto.Stopaj;
                response.Fon = calcDto.Fon;
                response.NetTutar = calcDto.NetTutar;
                response.Kdv = calcDto.Kdv;
                response.Tevkifat = calcDto.Tevkifat;
                response.NetKdv = calcDto.NetKdv;
                response.KdvliTutar = calcDto.KDVliTutar;
                response.HasError = false;
                response.Message = "success";
            }
            else
            {
                response.HasError = true;
                response.Message = "Not Found";
            }
            return response;
        }

     
    }
}
