using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZwei
{
    internal class Tier
    {
        protected int beine;
        protected string name;
        protected string art;
        protected bool flug;
        protected bool fell;
        protected bool carnivoire;
        protected string markierung; 
        protected string ort;

        public virtual void Beschreibung()
        {
            Console.WriteLine("");
            Console.WriteLine($"Dieses Tier heißt {name}.");
            Console.WriteLine($"{name} gehört der Art {art} an.");
            if (flug == true)
                Console.WriteLine($"{name} ist flugfähig.");
            if (carnivoire == true)
                Console.WriteLine($"Die Art {art} sind Raubtiere. Sie jagen gerne Touristen.");
        }

        public virtual void Wegbeschreibung()
        {
            Console.WriteLine($"Der Lebensort von {name} befindet sich {ort}.");
            Console.WriteLine($"Die Markierung finden sie auf der Karte bei {markierung}.");
        }
    }

    class mammal : Tier
    {
        private string fellfarbe;

        public mammal(string name,string art, int beine, bool flug, bool fell, string fellfarbe, bool carn, string ort, string mark)
        {
            this.name = name;
            this.beine = beine;
            this.flug = flug;
            this.fell= fell;
            this.fellfarbe = fellfarbe;
            this.carnivoire = carn;
            this.art = art;
            this.ort= ort;
            this.markierung = mark;
        }
        public override void Beschreibung()
        {
            base.Beschreibung();
            Console.WriteLine($"Mit {beine} Beinen kann {name} sich sehr schnell vorbewegen.");
        }
        public override void Wegbeschreibung()
        {
            base.Wegbeschreibung();
        }
    }

    class reptile : Tier
    {
        private string scales;
        public reptile(string name,string art, int beine, bool flug, bool fell, string scales, bool carn, string ort, string mark)
        {
            this.name = name;
            this.beine = beine;
            this.flug = flug;
            this.fell = fell;
            this.scales = scales;
            this.carnivoire = carn;
            this.art = art;
            this.ort = ort;
            this.markierung = mark;
        }
        public override void Beschreibung()
        {
            base.Beschreibung();
            Console.WriteLine($"{name} ist ein Reptil.(Oder ein Nacktmull, die Wissenschaft ist sich nicht sicher).");
            Console.WriteLine($"{name} hat die Schuppen in der Farbe {scales}");
        }
        public override void Wegbeschreibung()
        {
            base.Wegbeschreibung();
        }
    }

    class vogel :Tier
    {
        private string gefieder;

        public vogel(string name,string art, int beine, bool flug, bool fell, string gefieder, bool carn, string ort, string mark)
        {
            this.name = name;
            this.beine = beine;
            this.flug = flug;
            this.fell = fell;
            this.carnivoire = carn;
            this.gefieder = gefieder;
            this.art = art;
            this.ort = ort;
            this.markierung = mark;
        }
        public override void Beschreibung()
        {
            base.Beschreibung();
            Console.WriteLine($"Das Gefieder der {art} hat überwiegend eine {gefieder}e Farbe.");
        }
        public override void Wegbeschreibung()
        {
            base.Wegbeschreibung();
        }

    }
    
}
