using Xamarin.Forms;

namespace Rox
{
    public class WrapLayoutViewModel
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

        public WrapActualAdjustment[] WrapActualAdjustmentList =>
            new WrapActualAdjustment[]
            {
                WrapActualAdjustment.None,
                WrapActualAdjustment.StartIndex,
                WrapActualAdjustment.VisibleCount
            };

        private int _StartIndex = 0;
        public int StartIndex
        {
            get => _StartIndex;
            set
            {
                _StartIndex = value;

                OnPropertyChanged(nameof(StartIndex));
            }
        }

        private int _HorizontalStartIndex;
        public int HorizontalStartIndex
        {
            get => _HorizontalStartIndex;
            set
            {
                _HorizontalStartIndex = value;

                OnPropertyChanged(nameof(HorizontalStartIndex));
            }
        }

        private int _VerticalStartIndex;
        public int VerticalStartIndex
        {
            get => _VerticalStartIndex;
            set
            {
                _VerticalStartIndex = value;

                OnPropertyChanged(nameof(VerticalStartIndex));
            }
        }

        private int _VisibleCount = -1;
        public int VisibleCount
        {
            get => _VisibleCount;
            set
            {
                _VisibleCount = value;

                OnPropertyChanged(nameof(VisibleCount));
            }
        }

        private int _HorizontalVisibleCount;
        public int HorizontalVisibleCount
        {
            get => _HorizontalVisibleCount;
            set
            {
                _HorizontalVisibleCount = value;

                OnPropertyChanged(nameof(HorizontalVisibleCount));
            }
        }

        private int _VerticalVisibleCount;
        public int VerticalVisibleCount
        {
            get => _VerticalVisibleCount;
            set
            {
                _VerticalVisibleCount = value;

                OnPropertyChanged(nameof(VerticalVisibleCount));
            }
        }

        private int _MaximumCount = -1;
        public int MaximumCount
        {
            get => _MaximumCount;
            set
            {
                _MaximumCount = value;

                OnPropertyChanged(nameof(MaximumCount));
            }
        }

        private int _HorizontalActualCount;
        public int HorizontalActualCount
        {
            get => _HorizontalActualCount;
            set
            {
                _HorizontalActualCount = value;

                OnPropertyChanged(nameof(HorizontalActualCount));
            }
        }

        private int _VerticalActualCount;
        public int VerticalActualCount
        {
            get => _VerticalActualCount;
            set
            {
                _VerticalActualCount = value;

                OnPropertyChanged(nameof(VerticalActualCount));
            }
        }

        private WrapActualAdjustment _ActualAdjustment = WrapActualAdjustment.StartIndex;
        public WrapActualAdjustment ActualAdjustment
        {
            get => _ActualAdjustment;
            set
            {
                _ActualAdjustment = value;

                OnPropertyChanged(nameof(ActualAdjustment));
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

        private LayoutAlignment _HorizontalContentAlignment = LayoutAlignment.Center;
        public LayoutAlignment HorizontalContentAlignment
        {
            get => _HorizontalContentAlignment;
            set
            {
                _HorizontalContentAlignment = value;

                OnPropertyChanged(nameof(HorizontalContentAlignment));
            }
        }

        private double _HorizontalSpacing = 8d;
        public double HorizontalSpacing
        {
            get => _HorizontalSpacing;
            set
            {
                _HorizontalSpacing = value;

                OnPropertyChanged(nameof(HorizontalSpacing));
            }
        }

        private LayoutAlignment _VerticalContentAlignment = LayoutAlignment.Center;
        public LayoutAlignment VerticalContentAlignment
        {
            get => _VerticalContentAlignment;
            set
            {
                _VerticalContentAlignment = value;

                OnPropertyChanged(nameof(VerticalContentAlignment));
            }
        }

        private double _VerticalSpacing = 8d;
        public double VerticalSpacing
        {
            get => _VerticalSpacing;
            set
            {
                _VerticalSpacing = value;

                OnPropertyChanged(nameof(VerticalSpacing));
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
    }
}