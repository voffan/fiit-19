using System;
using System.Windows.Forms;

namespace CoCo.Forms
{
    public partial class Messages : UserControl
    {
        public static DialogResult ConfirmDelete()
        {
            return MessageBox.Show(
                "Вы уверены, что хотите удалить этот элемент?",
                "Удаление",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
        }
        public static void TooLong(string what)
        {
            MessageBox.Show(
                    "Поле " + what + " слишком длинное",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
        public static void WrongFormat(string what)
        {
            MessageBox.Show(
                    "Поле " + what + " содержит не поддерживаемый формат",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
        public static void ServerError()
        {
            MessageBox.Show(
                    "Ошибка соединения с сервером",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        public static void Empty()
        {
            MessageBox.Show(
                    "Заполните все поля",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
        public static DialogResult RepairComplete()
        {
            return MessageBox.Show(
                    "Успешно?",
                    "Сообщение",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
        }

    }
}
