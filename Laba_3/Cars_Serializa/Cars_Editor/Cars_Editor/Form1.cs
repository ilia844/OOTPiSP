using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Cars_Editor.Class_Manager;
using Cars_Editor.User_Classes;

namespace Cars_Editor
{
    public partial class FormCars : System.Windows.Forms.Form
    {
        private Class_Manager.Class_Manager class_manager;

        public FormCars()
        {
            InitializeComponent();
            class_manager = new Class_Manager.Class_Manager();
            string[] buf = class_manager.getClasses();
            cbCarBrand.Items.Clear();
            for (int i = 0; i < buf.Length; i++)
            {
                cbCarBrand.Items.Add(buf[i]);
            }
            tbProperty.Visible = false;
            cbProperty.Visible = false;
            btSetColor.Visible = false;
            pbViewColor.Visible = false;
        }


        private void btSaveChanges_Click(object sender, EventArgs e)
        {
            if (cbProperty.Visible)
                class_manager.SetPropVal(cbProperty.Text, cbProperty.SelectedIndex);
            if (btSetColor.Visible)
                class_manager.SetPropVal(pbViewColor.BackColor);
            if (tbProperty.Visible)
                if (!class_manager.SetPropVal(tbProperty.Text, 0))
                {
                    MessageBox.Show("wrong value!", "message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            //else
            //{
            //    if (btSetColor.Visible)
            //    {
            //        class_manager.SetPropVal(pbViewColor.BackColor);
            //    }
            //if (!class_manager.setpropval(tbproperty.text, 0))
            //{
            //    messagebox.show("wrong value!", "message", messageboxbuttons.ok,
            //        messageboxicon.error);
            //}
            //}
            UpdateObjs();
            UpdateProps();
        }

        private void UpdateObjs()
        {
            lbAllCars.Items.Clear();
            int buf = class_manager.getEditObjNum();
            for (int i = 0; i < class_manager.getObjNum(); i++)
            {
                class_manager.setActiveObj(i);
                lbAllCars.Items.Add(class_manager.GetName());
            }
            if (class_manager.getObjNum() > 0)
            {
                class_manager.setActiveObj(buf);
                lbAllCars.SelectedIndex = class_manager.getEditObjNum();
            }
        }

        private void UpdateProps()
        {
            lbCarInfo.Items.Clear();
            if (lbAllCars.SelectedIndex != -1)
            {
                string[] obj_info = class_manager.GetObjInfoTxt();
                for (int i = 0; i < obj_info.Length; i++)
                    lbCarInfo.Items.Add(obj_info[i]);
                lbCarInfo.SelectedIndex = class_manager.getEditPropNum();
                tbProperty.Visible = false;
                cbProperty.Visible = false;
                btSetColor.Visible = false;
                pbViewColor.Visible = false;
            }
        }

        private void btCreateCar_Click(object sender, EventArgs e)
        {
            if (cbCarBrand.Text == "")
                MessageBox.Show("Choose class pls!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                class_manager.createObject(cbCarBrand.Text);
                class_manager.setActiveLastObj();
                UpdateObjs();
                lbAllCars.SelectedIndex = class_manager.getEditObjNum();
            }
        }

        private void lbAllCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            class_manager.setActiveObj(lbAllCars.SelectedIndex);
            UpdateProps();
        }

        private void btRemoveCar_Click(object sender, EventArgs e)
        {
            if (lbAllCars.SelectedIndex == -1)
                MessageBox.Show("Нет выьранных объектов!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                class_manager.DeleteObj();
                UpdateObjs();
                UpdateProps();
            }
        }

        private void lbCarInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            class_manager.setActiveProp(lbCarInfo.SelectedIndex);
            cbProperty.Visible = class_manager.isEnumProp() && !class_manager.isColorProp();
            tbProperty.Visible = !class_manager.isEnumProp() && !class_manager.isColorProp();
            btSetColor.Visible = class_manager.isColorProp() && !class_manager.isEnumProp();
            pbViewColor.Visible = class_manager.isColorProp() && !class_manager.isEnumProp();
            cbProperty.Items.Clear();
            tbProperty.Clear();
            if (cbProperty.Visible)
            {
                string[] buf = class_manager.getEnumValues();
                for (int i = 0; i < buf.Length; i++)
                {
                    cbProperty.Items.Add(buf[i]);
                }
            }
            if (btSetColor.Visible)
            {
                Color color = class_manager.getColorValue();
                pbViewColor.BackColor = color;
            }
        }

        private void btSetColor_Click(object sender, EventArgs e)
        {
            if (cdCarColor.ShowDialog() == DialogResult.Cancel)
                return;
            pbViewColor.BackColor = cdCarColor.Color;
        }

        private void btSerialize_Click(object sender, EventArgs e)
        {
            class_manager.serializeObjects();
        }

        private void btDeserialize_Click(object sender, EventArgs e)
        {
            class_manager.deserializeObjects();
            UpdateObjs();
            UpdateProps();
        }
    }
}
