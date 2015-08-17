using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FormsDataScriptGenerator.Annotations;
using FormsDataScriptGenerator.Entities;
using FormsDataScriptGenerator.Generators;
using FormsDataScriptGenerator.Providers;
using Microsoft.Win32;

namespace FormsDataScriptGenerator
{
    public class MainModel : INotifyPropertyChanged
    {
        private readonly IFieldsProvider _fieldsProvider;
        private FieldItem _selectedField;
        private ObservableCollection<FieldItem> _fields;

        private readonly FieldsTypeProvider _fieldsTypeProvider;
        private readonly DataSetsGenerator _dataSetsGenerator;
        private readonly HtmlGenerator _htmlGenerator;
        private readonly LoadSaveProvider _loadSaveProvider;
        private readonly SqlGenerator _sqlGenerator;

        public MainModel(IFieldsProvider fieldsProvider, SqlGenerator sqlGenerator, FieldsTypeProvider fieldsTypeProvider, DataSetsGenerator dataSetsGenerator, HtmlGenerator htmlGenerator, LoadSaveProvider loadSaveProvider)
        {
            _fieldsProvider = fieldsProvider;
            _sqlGenerator = sqlGenerator;
            _fieldsTypeProvider = fieldsTypeProvider;
            _dataSetsGenerator = dataSetsGenerator;
            _htmlGenerator = htmlGenerator;
            _loadSaveProvider = loadSaveProvider;
        }

        public ObservableCollection<FieldItem> Fields
        {
            get { return _fields; }
            set
            {
                if (Equals(value, _fields)) return;
                _fields = value;
                OnPropertyChanged();
            }
        }

        public List<FieldTypeItem> FieldTypes { get; set; }

        public FieldItem SelectedField
        {
            get { return _selectedField; }
            set
            {
                _selectedField = value;
                OnPropertyChanged();
                OnPropertyChanged("Fields");
            }
        }

        public FieldTypeItem FieldType { get; set; }

        private ICommand _generateCommand;
        public ICommand GenerateCommand
        {
            get { return _generateCommand; }
        }

        private ICommand _newCommand;
        public ICommand NewCommand
        {
            get { return _newCommand; }
        }

        private ICommand _removeCommand;
        public ICommand RemoveCommand
        {
            get { return _removeCommand; }
        }

        private ICommand _saveCommand;
        public ICommand SaveCommand
        {
            get { return _saveCommand; }
        }

        private ICommand _loadCommand;
        public ICommand LoadCommand
        {
            get { return _loadCommand; }
        }

        public Guid FormID { get; set; }

        public void Init()
        {
            Fields = new ObservableCollection<FieldItem>(_fieldsProvider.GetFieldsList());
            
            FieldTypes = _fieldsTypeProvider.GetFieldTypes();

            _generateCommand = new RelayActionCommand() {ExecuteAction = OnGenerate };
            _newCommand = new RelayActionCommand() {ExecuteAction = OnNew };
            _removeCommand = new RelayActionCommand() {ExecuteAction = OnRemove };
            _saveCommand = new RelayActionCommand() {ExecuteAction = OnSave };
            _loadCommand = new RelayActionCommand() {ExecuteAction = OnLoad };
            
        }

        private void OnLoad(object obj)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Fields = new ObservableCollection<FieldItem>(_loadSaveProvider.Load(openFileDialog.FileName));
            }
        }

        private void OnSave(object obj)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                _loadSaveProvider.Save(Fields.ToList(), saveFileDialog.FileName);
            }
        }

        private void OnRemove(object obj)
        {
            Fields.Remove(SelectedField);
            SelectedField = null;
        }

        private void OnNew(object o)
        {
            FieldItem newValue = new FieldItem(Guid.NewGuid(),FieldTypes[0]);
            Fields.Add(newValue);
            SelectedField = newValue;
        }

        private void OnGenerate(object param)
        {
            //PrepareFields();
            _sqlGenerator.Generate(Fields.ToList(), FormID);
            _dataSetsGenerator.Generate(Fields.ToList(), FormID);
            _htmlGenerator.Generate(Fields.ToList(),FormID);
        }

        private void PrepareFields()
        {
            foreach (FieldItem field in Fields)
            {
                field.Title = field.Title.Replace('’', ' ');
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
