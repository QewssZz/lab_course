using Queues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab_course
{
    class ViewDetailed : View
    {
        private Form1 frm;
        public ViewDetailed(Model model, Controller controller, Form1 frm) :
        base(model, controller)
        {
            this.frm = frm;
        }

        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            
        }

        public override void DataBind()
        {
            //привязка счетчика тактов
            frm.lblTime.DataBindings.Add(new Binding("Text", model.clock, "Clock"));

            //привязка активного процесса(процесор)
            frm.label17.DataBindings.Add(new Binding("Text", model.cpu, "ActiveProcess"));

            //привязка активного процесса(внешнее устройство)
            frm.lblDevice_1.DataBindings.Add(new Binding("Text", model.device, "ActiveProcess"));

            //свободная память
            frm.FreeSize.DataBindings.Add(new Binding("Text", model.ram, "FreeSize"));

            //занятая память процессами
            frm.OccupiedSize.DataBindings.Add(new Binding("Text", model.ram, "OccupiedSize"));


            Binding intensityBinding = new Binding("Value", model.modelSettings, "Intensity");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.nudIntensity.DataBindings.Add(intensityBinding);

            Binding priorityBinding = new Binding("Value", model.modelSettings, "LowPriority");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.nudPriority.DataBindings.Add(priorityBinding);

            Binding burstMinBinding = new Binding("Value", model.modelSettings, "MinValueOfBurstTime");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.nudBurstMin.DataBindings.Add(burstMinBinding);

            Binding burstMaxBinding = new Binding("Value", model.modelSettings, "MaxValueOfBurstTime");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.nudBurstMax.DataBindings.Add(burstMaxBinding);

            Binding addrSpaceMinBinding = new Binding("Value", model.modelSettings, "MinValueOfAddrSpace");
            addrSpaceMinBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.nudAddrSpaceMin.DataBindings.Add(addrSpaceMinBinding);

            Binding addrSpaceMaxBinding = new Binding("Value", model.modelSettings, "MaxValueOfAddrSpace");
            addrSpaceMaxBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.nudAddrSpaceMax.DataBindings.Add(addrSpaceMaxBinding);

            Binding ramSizeBinding = new Binding("SelectedItem", model.modelSettings, "ValueOfRAMSize", true);
            ramSizeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.cbRamSize.DataBindings.Add(ramSizeBinding);

            Subscribe();
        }
        public override void DataUnbind() { }

        // подписчик
        private void Subscribe()
        {
            model.PropertyChanged += new PropertyChangedEventHandler(PropertyChangedHandler);
        }
        private void Unsubscribe()
        {
            model.PropertyChanged -= PropertyChangedHandler;
        }
        private void updateListBox(IQueueable<Process> queue, ListBox lb)
        {
            lb.Items.Clear();
            if (queue.Count != 0)
            {
                lb.Items.AddRange(queue.ToArray());
            }
        }
        //private void updateListBox(HPFArray queue, ListBox lb)
        //{
        //    lb.Items.Clear();
        //    if (queue.Count != 0)
        //    {
        //        lb.Items.AddRange(queue.ToArray());
        //    }
        //}

    }
}
