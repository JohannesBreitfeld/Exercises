using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Dialogrutor.Exercises
{
    /// <summary>
    /// Interaction logic for E4.xaml
    /// </summary>
    public partial class E4 : Window
    {
        public string? CurrentFile { get; set; }
        public bool IsEdited { get; set; }
        public E4()
        {
            InitializeComponent();
        }

        private void UpdateTitle()
        {
            if (string.IsNullOrEmpty(CurrentFile))
                Title = "Untitled Document" + (IsEdited ? "*" : "");
            else
                Title = System.IO.Path.GetFileName(CurrentFile) + (IsEdited ? "*" : "");
        }


        private void MenuClickOpen(object sender, RoutedEventArgs e)
        {
            if (GetConfirmation())
            {
                var dialog = new OpenFileDialog()
                {
                    InitialDirectory = Directory.GetCurrentDirectory(),
                    Filter = "Textfiler (*.txt)|*.txt|Alla filer (*.*)|*.*"
                };
               
                if (dialog.ShowDialog() == true)
                {
                    CurrentFile = dialog.FileName;
                    textBox.Text = File.ReadAllText(CurrentFile);
                    IsEdited = false;
                    UpdateTitle();
                }
            }
        }

        private void MenuClickExit(object sender, RoutedEventArgs e)
        {
            WindowE4.Close();
        }

        private void MenuClickSave(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentFile))
            {
                MenuClickSaveAs(sender, e);
            }
            else
            {
                File.WriteAllText(CurrentFile, textBox.Text);
                IsEdited = false;
                UpdateTitle();
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            IsEdited = true;
            UpdateTitle();
            UpdateStatusBar();
        }

        private void MenuClickNew(object sender, RoutedEventArgs e)
        {
            if (GetConfirmation())
            {
                textBox.Clear();
                CurrentFile = null;
                IsEdited = false;
                UpdateTitle();
            }
        }
        private bool GetConfirmation()
        {
            if (!IsEdited) return true;

            MessageBoxResult result = MessageBox.Show("Do you want to save changes?", "Confirm", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                MenuClickSave(null, null);
                return true;
            }
            else if (result == MessageBoxResult.No)
            {
                return true;
            }
            return false;
        }

        private void MenuClickSaveAs(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                FileName = string.IsNullOrEmpty(CurrentFile) ? "Untitled Document.txt" : System.IO.Path.GetFileName(CurrentFile),
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            if (dialog.ShowDialog() == true)
            {
                CurrentFile = dialog.FileName;
                File.WriteAllText(CurrentFile, textBox.Text);
                IsEdited = false;
                UpdateTitle();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (GetConfirmation())
            {
                return;
            }
            e.Cancel = true;
        }

        private void textBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            UpdateStatusBar();
        }
        private void UpdateStatusBar()
        {
            int line = textBox.GetLineIndexFromCharacterIndex(textBox.CaretIndex) + 1;
            int column = textBox.CaretIndex - textBox.GetCharacterIndexFromLineIndex(textBox.GetLineIndexFromCharacterIndex(textBox.CaretIndex)) +1 ;
            int charCount = textBox.Text.Length; 

            textBloxkPosition.Text = $"Line: {line}, Column: {column}";
            textBlockCharCount.Text = $"Total characters: {charCount}";
        }
    }
}
