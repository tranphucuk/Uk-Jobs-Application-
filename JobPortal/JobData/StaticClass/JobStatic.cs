using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace JobPortal.JobData
{
    public class JobStatic
    {
        private static readonly JobStatic instace = new JobStatic();
        static JobStatic() { } // Make sure it's truly lazy
        private JobStatic() { } // Prevent instantiation outside

        public static JobStatic Instance => instace;

        public List<Industry> Industries = new List<Industry>()
        {
            new Industry(){Id ="0",Name="---------- Select an industry ----------"},
            new Industry(){Id ="administrative and support",Name="Administrative and Support"},
            new Industry(){Id ="transportation,storage",Name="Transportation & Storage"},
            new Industry(){Id ="social work",Name="Social Work"},
            new Industry(){Id ="real estate",Name="Real Estate"},
            new Industry(){Id ="public administration, government",Name="Public Administration,Government"},
            new Industry(){Id ="others",Name="Others"},
            new Industry(){Id ="mining and quarrying",Name="Mining and Quarrying"},
            new Industry(){Id ="manufacturing",Name="Manufacturing"},
            new Industry(){Id ="management",Name="Management"},
            new Industry(){Id ="it,telecommunication",Name="IT,Telecommunication"},
            new Industry(){Id ="houselhold",Name="Houselhold"},
            new Industry(){Id ="food,accomodation",Name="Food & Accomodation"},
            new Industry(){Id ="finance,insurance",Name="Finance,Insurance"},
            new Industry(){Id ="electricity,gas,steam,air",Name="Electricity,Gas,Steam,Air"},
            new Industry(){Id ="education",Name="Education"},
            new Industry(){Id ="construction",Name="Construction"},
            new Industry(){Id ="arts ,entertainment",Name="Arts,Entertainment"},
            new Industry(){Id ="agriculture",Name="Agriculture"},
            new Industry(){Id ="water,waste management",Name="Water,Waste Management"},
            new Industry(){Id ="wholesale,retail",Name="Wholesale & Retail"},
        };

        public List<Tier> Tiers = new List<Tier>()
        {
            new Tier(){Id ="0",Name="----- Tier -----"},
            new Tier(){Id ="1",Name="Tier 2"},
            new Tier(){Id ="2",Name="Tier 5"},
            new Tier(){Id ="3",Name="Both"},
        };
    }
}
