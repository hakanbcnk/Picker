﻿namespace Picker
{
    using System.Windows.Forms;

    internal partial class ProcessorListView : Form, IProcessorListView
    {
        private readonly ProcessorListPresenter _presenter;

        public ProcessorListView(ProcessorListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        public bool GeneratingList
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        public int ItemPerPage => throw new System.NotImplementedException();

        public int OrderIndex
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        public int PageCount
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        public int PageIndex
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        public void UpdateNavigationButtonsStatus() => throw new System.NotImplementedException();

        public void SetCountLabel(int itemCount, int totalItemCount) => throw new System.NotImplementedException();
    }
}