using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlManager;


namespace Sharp7Form2
{
    public partial class nameLabel : UserControl
    {
        private moveAndResize manager;
        private bool editMode = false;
        public nameLabel()
        {
            InitializeComponent();
            manager = new moveAndResize();
            manager.Initialize(label1, this, editMode);
        }
        public void edit(bool enableEdit)
        {
            editMode = enableEdit;
            manager.changeEditMode(enableEdit);
        }

    }
}
