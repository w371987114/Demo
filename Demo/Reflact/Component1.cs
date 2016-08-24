using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflact
{
    public partial class IP : Component
    {
        public IP()
        {
            InitializeComponent();
        }

        public IP(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
