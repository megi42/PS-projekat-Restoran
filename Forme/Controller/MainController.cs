using Forme.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme.Controller
{
    public class MainController
    {
        internal void OpenUCAllProducts(FrmMain frmMain)
        {
            frmMain.SetUserControl(new UCAllProducts(new Controller.ProductController()));
        }

        internal void OpenUCProduct(FrmMain frmMain)
        {
            frmMain.SetUserControl(new UCProduct(new Controller.ProductController()));
        }

        internal void OpenUCRemoveProduct(FrmMain frmMain)
        {
            frmMain.SetUserControl(new UCRemoveProduct(new Controller.ProductController()));
        }

        internal void OpenUCAllOrders(FrmMain frmMain)
        {
            frmMain.SetUserControl(new UCAllOrders(new Controller.OrderController()));
        }

        internal void OpenUCOrder(FrmMain frmMain)
        {
            frmMain.SetUserControl(new UCOrder(new Controller.OrderController()));
        }

        internal void OpenUCChangeOrder(FrmMain frmMain)
        {
            frmMain.SetUserControl(new UCChangeOrder(new Controller.OrderController()));
        }

        internal void OpenUCInvoice(FrmMain frmMain)
        {
            frmMain.SetUserControl(new UCInvoice(new Controller.OrderController()));
        }
    }
}
