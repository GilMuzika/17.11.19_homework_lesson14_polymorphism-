using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace _17._11._19_homework_lesson14_Vehicles_Itay
{
    public partial class Form1 : Form
    {
        private Carrier _currentCarrier = new Carrier();

        public Form1()
        {
            InitializeComponent();
            initialiseSomeControls();
        }
        private void initialiseSomeControls()
        {
            foreach (var s in GetClasses().Select(x => x.Name).Where(x => x.Contains("__") && !x.Contains("<>")).Select(x => x.Replace("__", ""))) cmbCreateNew.Items.Add(new ComboItem(s, "Create a new"));
            cmbCreateNew.SelectedIndex = 0;
        }


        private VehicleWithTypeContainer createNew()
        {
            switch ((cmbCreateNew.SelectedItem as ComboItem).Value)
            {
                case "Car":
                    Car__ car = new Car__((int)numNUmberOfWheels.Value, txtModel.Text, (int)numNumDoorshandbrakes.Value);
                    return new VehicleWithTypeContainer(car.GetType(), car);
                case "Motorcycle":
                    Motorcycle__ motorcycle = new Motorcycle__((int)numNUmberOfWheels.Value, txtModel.Text, (int)numNumDoorshandbrakes.Value);
                    return new VehicleWithTypeContainer(motorcycle.GetType(), motorcycle);

            }


            return null;





        }


        IEnumerable<Type> GetClasses()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            return asm.GetTypes()
                .Where(type => type.Namespace == this.GetType().Namespace);
        }

        private void cmbCreateNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNumOfDoordHandbrakes.Text = string.Empty;
            switch ((cmbCreateNew.SelectedItem as ComboItem).Value)
            {
                case "Car":
                    lblNumOfDoordHandbrakes.Text += "Number of doors:";
                    numNUmberOfWheels.Value = 4;
                    numNumDoorshandbrakes.Value = 4;
                    numNumberOfPassengers.Value = 5;
                    txtModel.Text = "Toyota Corola";
                    break;
                case "Motorcycle":
                    lblNumOfDoordHandbrakes.Text += "Number of hanbrakes:";
                    numNUmberOfWheels.Value = 2;
                    numNumDoorshandbrakes.Value = 1;
                    numNumberOfPassengers.Value = 2;
                    txtModel.Text = "Harley Davidson";
                    break;
            }
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            _currentCarrier.Vehicles.Add(createNew());
            updateCmbVehicles();
        }

        private void updateCmbVehicles()
        {
            cmbVehicles.Items.Clear();
            foreach (var s in _currentCarrier.Vehicles) cmbVehicles.Items.Add(s);
            cmbVehicles.SelectedIndex = 0;
        }



        private void cmbVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textString = string.Empty;

            textString += cmbVehicles.Text + Environment.NewLine;
            textString += "---------------------------------------------------------------------" + Environment.NewLine;
            textString += (cmbVehicles.SelectedItem as VehicleWithTypeContainer).VehicleItself.ToString();

            rtbVehicleDetails.Text = textString;
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            Form infoOutputForm = new Form();
            infoOutputForm.AutoSize = true;
            infoOutputForm.Text = btnPrintAll.Text;
            Label infoOutputLabel = new Label();
            infoOutputLabel.AutoSize = true;
            infoOutputLabel.Location = new Point(10, 10);
            infoOutputLabel.Text = _currentCarrier.ToString();
            infoOutputForm.Width = infoOutputLabel.Width + 10;
            infoOutputForm.Height = infoOutputLabel.Height + 10;
            infoOutputForm.Controls.Add(infoOutputLabel);
            infoOutputForm.Show();

        }
    }
}
