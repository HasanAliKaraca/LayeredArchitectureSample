using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LayeredArchitectureSample.Presentation;
using StructureMap;

namespace LayeredArchitectureSample.WebUI
{
    public partial class Default : System.Web.UI.Page, Presentation.IProductListView
    {
        private ProductListPresenter _presenter;

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new ProductListPresenter(this, ObjectFactory.GetInstance<Service.ProductService>());

            this.ddlCustomerType.SelectedIndexChanged += delegate { _presenter.Display(); };

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack != true)
                _presenter.Display();
        }

        #region IProductListView Members

        public void Display(IList<Service.ProductViewModel> products)
        {
            rptProducts.DataSource = products;
            rptProducts.DataBind();
        }

        public Model.EnmCustomerType EnmCustomerType
        {
            get { return (Model.EnmCustomerType)Enum.ToObject(typeof(Model.EnmCustomerType), int.Parse(this.ddlCustomerType.SelectedValue)); }
        }

        public string ErrorMessage
        {
            set { lblErrorMessage.Text = string.Format("<p><strong>Error</strong><br/>{0}</p>", value); }
        }


        #endregion
    }
}