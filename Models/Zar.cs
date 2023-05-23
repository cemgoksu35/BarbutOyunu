using System;
namespace Barbut.Models
{
    class Zar
    {
        //  public byte Sayi { get; set; } // Özellik olarak tanımlanırsa Zar zar=new Zar(); buna atama yapabiliriz. (Sayi=5;)

        int _sayi;
        Random _rastgele = new Random();// class-datetime-array gibi kullanımlarda newlemek zorunludur.

        string _yuz;
        public string Yuz
        {

            get
            {
                _yuz = "";
                switch (_sayi)
                {
                    case 1:
                        _yuz += "---\n";
                        _yuz += "-*-\n";
                        _yuz += "---\n";
                        break;

                    case 2:
                        _yuz += "*--\n";
                        _yuz += "---\n";
                        _yuz += "--*\n";
                        break;

                    case 3:
                        _yuz += "*--\n";
                        _yuz += "-*-\n";
                        _yuz += "--*\n";
                        break;
                    case 4:
                        _yuz += "*-*\n";
                        _yuz += "---\n";
                        _yuz += "*-*\n";
                        break;
                    case 5:
                        _yuz += "*-*\n";
                        _yuz += "-*-\n";
                        _yuz += "*-*\n";
                        break;
                    default:
                        _yuz += "***\n";
                        _yuz += "---\n";
                        _yuz += "***\n";
                        break;
                }
                return _yuz;
            }

        }


        public int At()
        {
           
            _sayi = _rastgele.Next(1, 7);// Overloadlardan minimum ve maksimum değeri olan kullanımı görüp bu kullanımı seçiyoruz.7 seçmemizin nedeni <7 mantığının olması.
            return _sayi;

        }

    }
}
