using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace TallerMecanico.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem("Catalogos")]
    [FriendlyKeyProperty("MarcaAuto")]
    public class AutoMarca : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
        public AutoMarca(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (http://documentation.devexpress.com/#Xaf/CustomDocument2834).
        }
        private string _MarcaAuto;

        [RuleRequiredField]
        [RuleUniqueValue]
        public string MarcaAuto
        {
            get
            {
                return _MarcaAuto;
            }
            set
            {
                SetPropertyValue("MarcaAuto", ref _MarcaAuto, value);
            }
        }
    }
}
