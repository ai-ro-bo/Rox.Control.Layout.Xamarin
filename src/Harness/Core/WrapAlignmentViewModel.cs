using Xamarin.Forms;

namespace Rox
{
    public class WrapAlignmentViewModel
        : ViewModelBase
    {
        public LayoutAlignment[] LayoutAlignmentList =>
            new LayoutAlignment[]
            {
                LayoutAlignment.Start,
                LayoutAlignment.Center,
                LayoutAlignment.End,
                LayoutAlignment.Fill
            };

        public LayoutOrientationReverse[] LayoutOrientationReverseList =>
            new LayoutOrientationReverse[]
            {
                LayoutOrientationReverse.None,
                LayoutOrientationReverse.Horizontal,
                LayoutOrientationReverse.Vertical,
                LayoutOrientationReverse.Both
            };

        private LayoutAlignment _HorizontalContentAlignment = LayoutAlignment.Start;
        public LayoutAlignment HorizontalContentAlignment
        {
            get => _HorizontalContentAlignment;
            set
            {
                _HorizontalContentAlignment = value;

                OnPropertyChanged(nameof(HorizontalContentAlignment));
            }
        }

        private LayoutAlignment _EndParagraphContentAlignment = LayoutAlignment.Fill;
        public LayoutAlignment EndParagraphContentAlignment
        {
            get => _EndParagraphContentAlignment;
            set
            {
                _EndParagraphContentAlignment = value;

                OnPropertyChanged(nameof(EndParagraphContentAlignment));
            }
        }

        private LayoutOrientationReverse _OrientationReverse = LayoutOrientationReverse.None;
        public LayoutOrientationReverse OrientationReverse
        {
            get => _OrientationReverse;
            set
            {
                _OrientationReverse = value;

                OnPropertyChanged(nameof(OrientationReverse));
            }
        }

        private int _Padding = 4;
        public int Padding
        {
            get => _Padding;
            set
            {
                _Padding = value;

                OnPropertyChanged(nameof(Padding));
            }
        }

        private double _HorizontalSpacing = 4d;
        public double HorizontalSpacing
        {
            get => _HorizontalSpacing;
            set
            {
                _HorizontalSpacing = value;

                OnPropertyChanged(nameof(HorizontalSpacing));
            }
        }

        private double _VerticalSpacing = 4d;
        public double VerticalSpacing
        {
            get => _VerticalSpacing;
            set
            {
                _VerticalSpacing = value;

                OnPropertyChanged(nameof(VerticalSpacing));
            }
        }
    }
}