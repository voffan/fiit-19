using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public enum Pledge_
    {
        [Description("Деньги")]
        money = 0,
        [Description("Документ подтверждающий личность")]
        document = 1,
        [Description("Другое")]
        other = 3
    }

    public class Order
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Employee Employee { get; set; }
        public Pledge_ Pledge { get; set; }
        [MaxLength(100)] public string PledgeDescription { get; set; }
    }
}
