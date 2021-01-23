using System;
using System.Drawing;
using System.Windows.Forms;
using Patterns.Behavioral.Observer.ConcreteSubjects;

namespace Patterns.Behavioral.Observer.ConcreteObservers
{
    public class DigitalClock : Observer
    {
        private TimeSpan _time;
        private readonly Label _digitLabel;

        public DigitalClock(Control parentControl, Subject subject)
        {
            _digitLabel = new Label()
            {
                Parent = parentControl,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial",15, FontStyle.Bold),
                Dock = DockStyle.Fill
            };
            
            subject.Attach(this);
        }

        public override void Update(Subject subject)
        {
            _time = ((ClockTimer) subject).GetTime();

            if(_digitLabel.InvokeRequired)
                _digitLabel.BeginInvoke(new Action(Draw));
        }

        public void Draw()
        {
            _digitLabel.Text = _time.ToString("hh\\:mm\\:ss");
        }
    }
}