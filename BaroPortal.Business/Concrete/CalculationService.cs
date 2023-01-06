using BaroPortal.Business.Abstract;
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

        public class smmh
        {
            public double? net { get; set; }
            public double? brut { get; set; }   
            public double? kdvliTutar { get; set; } 
            public double? tevkifat { get; set; }
            public double? netKdv { get; set; }
        }
        public smmh CalcReceipt(String? type,double? amount, double? kdv, double? stopaj, double? fon, double? tevkifat)
        {
            smmh result = new smmh();
            switch (type)
            {
                case "Brüt Tutar":
                    result.brut= amount;
                    result.net = 0;
                    result.kdvliTutar = result.net + kdv;
                    result.netKdv = (kdv - kdv * tevkifat / 100);
                    if (stopaj == 0)
                    {
                        fon = 0;
                        if (tevkifat == 0)
                        {
                            result.net = result.brut;
                            result.kdvliTutar = result.net + kdv;
                        }
                        else if (tevkifat > 0)
                        {
                            result.net = result.brut;
                            result.kdvliTutar = result.net + result.netKdv;
                        }

                        else
                        {
                            
                        }
                    }
                    else if (stopaj > 0)
                    {
                        if (fon == 0 && tevkifat == 0)
                        {
                            result.net = result.net - result.brut * stopaj / 100;
                            result.kdvliTutar = result.net + kdv;
                        }
                        else if (fon > 0 && tevkifat == 0)
                        {
                            result.net = result.brut - result.brut * stopaj / 100 - stopaj * fon / 100;
                            result.kdvliTutar = result.net + kdv;
                        }
                        else if (fon == 0 && tevkifat > 0)
                        {
                            result.net = result.brut - result.brut * stopaj / 100;
                            result.kdvliTutar = result.net + result.netKdv;
                            result.tevkifat = tevkifat * 10;
                        }
                        else if (fon > 0 && tevkifat > 0)
                        {
                            result.net = result.brut - result.brut * stopaj / 100 - stopaj * fon / 100;
                            result.kdvliTutar = result.net + result.netKdv;
                            result.tevkifat = tevkifat * 10;

                        }
                        else
                        {
                            
                        }
                    }
                    break;
                case "Net Tutar":
                    result.brut = 0;
                    result.net = amount;
                    result.kdvliTutar = result.net + kdv;
                    result.netKdv = (kdv - kdv * tevkifat / 100);
                    if (stopaj == 0)
                    {
                        fon = 0;
                        if (tevkifat == 0)
                        {
                            result.kdvliTutar = result.net + kdv;
                            result.brut = result.net;
                            result.tevkifat = tevkifat * 10;

                        }
                        else if (tevkifat > 0)
                        {

                            result.kdvliTutar = result.net + result.netKdv;
                            result.brut = result.net;
                            result.tevkifat = tevkifat * 10;
                        }

                        else
                        {
                            
                        }
                    }
                    else if (stopaj > 0)
                    {
                        if (fon == 0 && tevkifat == 0)
                        {

                            result.brut = result.net - result.net / (1 - stopaj);
                            result.kdvliTutar = result.net + kdv;
                        }
                        else if (fon > 0 && tevkifat == 0)
                        {

                            result.brut = result.net - (result.net + (stopaj * fon / 100)) / (1 - stopaj);
                            result.kdvliTutar = result.net + kdv;
                        }
                        else if (fon == 0 && tevkifat > 0)
                        {
                            result.brut = result.net - result.net / (1 - stopaj);
                            result.kdvliTutar = result.net + result.netKdv;
                            result.tevkifat = tevkifat * 10;
                        }
                        else if (fon > 0 && tevkifat > 0)
                        {
                            result.brut = result.net - (result.net + (stopaj * fon / 100)) / (1 - stopaj);
                            result.kdvliTutar = result.net + result.netKdv;
                            result.tevkifat = tevkifat * 10;
                        }
                        else
                        {
                            
                        }
                    }
                    break;
                case "KDV Dahil Tahsil Edilecek Tutar":
                    result.brut = 0;

                    result.kdvliTutar = amount;
                    result.net = amount - kdv + result.kdvliTutar;
                    result.netKdv = (kdv - kdv * tevkifat / 100);
                    if (stopaj == 0)
                    {
                        fon = 0;
                        if (tevkifat == 0)
                        {


                            result.net = result.kdvliTutar -kdv;
                            result.brut = result.net;
                        }
                        else if (tevkifat > 0)
                        {


                            result.net = result.kdvliTutar - result.netKdv;
                            result.brut = result.net;
                            result.tevkifat = tevkifat * 10;
                        }

                        else
                        {
                            
                        }
                    }
                    else if (stopaj > 0)
                    {
                        if (fon == 0 && tevkifat == 0)
                        {
                            result.net = result.kdvliTutar - kdv;
                            result.brut = result.net - result.net / (1 - stopaj);

                        }
                        else if (fon > 0 && tevkifat == 0)
                        {
                            result.net = result.kdvliTutar - kdv;
                            result.brut = result.net - (result.net + (stopaj * fon / 100)) / (1 - stopaj);

                        }
                        else if (fon == 0 && tevkifat > 0)
                        {
                            result.net = result.kdvliTutar - result.netKdv;
                            result.brut = result.net - result.net / (1 - stopaj);
                            result.tevkifat = tevkifat * 10;

                        }
                        else if (fon > 0 && tevkifat > 0)
                        {
                            result.net = result.kdvliTutar - result.netKdv;
                            result.brut = result.net - (result.net + (stopaj * fon / 100)) / (1 -stopaj);
                            result.tevkifat = tevkifat * 10;

                        }
                        else
                        {
                         
                        }
                    }
                    break;
                default:

                    break;
            }
            return result;
        }

        public SMMHResultDto ReceiptCalculate(SMMH calcDto)
        {
            SMMHResultDto response = new SMMHResultDto();


            double? Tevkifat = (calcDto.Tevkifat);
            double? NetKdv = (calcDto.Kdv - calcDto.Kdv * Tevkifat);
            int? tur = 0;
            

            if (calcDto.Tur == "Brüt Tutar")
            {
                

                tur = 1;
                //smmh result = new smmh();
                //result = CalcReceipt(tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat);
                calcDto.BrutTutar = CalcReceipt(calcDto.Tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat).brut;
                calcDto.NetTutar = CalcReceipt(calcDto.Tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat).net;
                calcDto.KDVliTutar = CalcReceipt(calcDto.Tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat).kdvliTutar;
                calcDto.NetKdv = CalcReceipt(calcDto.Tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat).netKdv;
                response.Tur = calcDto.Tur;
                response.BrutTutar = calcDto.BrutTutar;
                response.Stopaj = calcDto.Stopaj;
                response.Fon = calcDto.Fon;
                response.NetTutar =calcDto.NetTutar;
                response.Kdv = calcDto.Kdv;
                response.Tevkifat = calcDto.Tevkifat;
                response.NetKdv = calcDto.NetKdv;
                response.KdvliTutar = calcDto.KDVliTutar;
                response.HasError = false;
                response.Message = "success";
            }
            else if(calcDto.Tur == "Net Tutar")
            {
                tur = 2;
               // smmh result = new smmh();
                //result = CalcReceipt(tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat);


                calcDto.BrutTutar = CalcReceipt(calcDto.Tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat).brut;
                calcDto.NetTutar = CalcReceipt(calcDto.Tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat).net;
                calcDto.KDVliTutar = CalcReceipt(calcDto.Tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat).kdvliTutar;
                calcDto.NetKdv = CalcReceipt(calcDto.Tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat).netKdv;
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
                tur = 3;
                //smmh result = new smmh();
               //result = CalcReceipt(tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat);

                calcDto.BrutTutar = CalcReceipt(calcDto.Tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat).brut;
                calcDto.NetTutar = CalcReceipt(calcDto.Tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat).net;
                calcDto.KDVliTutar = CalcReceipt(calcDto.Tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat).kdvliTutar;
                calcDto.NetKdv = CalcReceipt(calcDto.Tur, calcDto.Amount, calcDto.Kdv, calcDto.Stopaj, calcDto.Fon, calcDto.Tevkifat).netKdv;
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

        public ResponseCalculationDto LevyInterestCalculate(IFH calcDto)
        {
            ResponseCalculationDto response = new ResponseCalculationDto();
            TimeSpan timespan = (TimeSpan)(calcDto.End - calcDto.Start);
            double totDay = timespan.TotalDays; 

            if (calcDto.TotDay == "360")
            {
                response.total = calcDto.Amount + (totDay / 360) * calcDto.Amount * calcDto.InterestPercent/100;
                response.HasError = false;
                response.Message = "successful";
            }
            else if(calcDto.TotDay == "365")
            {
                response.total = calcDto.Amount + (totDay / 365) * calcDto.Amount * calcDto.InterestPercent/100;
                response.HasError = false;
                response.Message = "successful";
            }
            else
            {
                response.HasError = true;
                response.Message = "fail";
            }
            return response;
        }

        //public ResponseCalculationDto LevyMortarCalculate(IHH calcDto)
        //{
        //    ResponseCalculationDto response = new ResponseCalculationDto();
        //    if()
        //}
    }
}
