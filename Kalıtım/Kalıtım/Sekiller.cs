using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class Sekiller
    {

        private string _olusturmaTarihi;

        public string oluşturmaTarihi
        {
            get { return _olusturmaTarihi; }
            set { _olusturmaTarihi = value; }
        }

        private bool _doluMu;

        public bool doluMu
        {
            get { return _doluMu; }
            set { _doluMu = value; }
        }
        public char sembol = '*';
        public void SetSembol(char sembol)
        {
            this.sembol = sembol;
        }
        public Sekiller()
        {
            oluşturmaTarihi = DateTime.Today.ToString();
        }
        public Sekiller(char sombol)
        {

        }
        public Sekiller(char sembol, bool doluMu)
        {

        }

        public void AlanHesapla()
        {

        }
     
    }
}
