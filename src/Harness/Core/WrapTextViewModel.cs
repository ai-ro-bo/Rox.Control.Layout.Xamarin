using Xamarin.Forms;

namespace Rox
{
    public class WrapTextViewModel
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

        private LayoutAlignment _HorizontalContentAlignment = LayoutAlignment.Fill;
        public LayoutAlignment HorizontalContentAlignment
        {
            get => _HorizontalContentAlignment;
            set
            {
                _HorizontalContentAlignment = value;

                OnPropertyChanged(nameof(HorizontalContentAlignment));
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

        private LayoutAlignment _VerticalContentAlignment = LayoutAlignment.Start;
        public LayoutAlignment VerticalContentAlignment
        {
            get => _VerticalContentAlignment;
            set
            {
                _VerticalContentAlignment = value;

                OnPropertyChanged(nameof(VerticalContentAlignment));
            }
        }

        private double _VerticalSpacing = 2d;
        public double VerticalSpacing
        {
            get => _VerticalSpacing;
            set
            {
                _VerticalSpacing = value;

                OnPropertyChanged(nameof(VerticalSpacing));
            }
        }

        private LayoutAlignment _EndParagraphContentAlignment = LayoutAlignment.Start;
        public LayoutAlignment EndParagraphContentAlignment
        {
            get => _EndParagraphContentAlignment;
            set
            {
                _EndParagraphContentAlignment = value;

                OnPropertyChanged(nameof(EndParagraphContentAlignment));
            }
        }
    }
}