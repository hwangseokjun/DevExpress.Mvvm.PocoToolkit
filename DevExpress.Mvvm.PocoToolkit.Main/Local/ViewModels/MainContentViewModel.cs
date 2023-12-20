using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Mvvm.PocoToolkit.Main.Local.ViewModels
{
    [POCOViewModel]
    public class MainContentViewModel
    {
        public virtual string Text { get; set; }

        public MainContentViewModel()
        {
            Text = "test binding";
        }
    }
}
