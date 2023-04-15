/*
 * File: FormValidator.cs
 * Author: Antonio F. Huertas 841-##-####
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 03/28/2023
 * Purpose: This utility class contains validation methods for the form controls.
 */

using System.Text.RegularExpressions;

namespace HourlyEmployeeMaintenanceApp.Presentation
{
    /// <summary>
    /// A validation utility class for the form controls.
    /// </summary>
    public static class FormValidator
    {
        /// <summary>The title of the validation error message box.</summary>
        public static string Title { get; set; } = "Entry Error";

        /// <summary>
        /// Determines whether the given textbox contains data.
        /// </summary>
        /// <param name="textBox">The textbox to be validated.</param>
        /// <returns>true if the textbox contains data; false otherwise.</returns>
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show($"{textBox.Tag} is required.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the given textbox contains a valid integer.
        /// </summary>
        /// <param name="textBox">The textbox to be validated.</param>
        /// <returns>true if the textbox contains an integer; false otherwise.</returns>
        public static bool IsInt32(TextBox textBox)
        {
            if (!int.TryParse(textBox.Text, out _))
            {
                MessageBox.Show($"{textBox.Tag} should be an integer.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the given textbox contains a valid decimal.
        /// </summary>
        /// <param name="textBox">The textbox to be validated.</param>
        /// <returns>true if the textbox contains a decimal; false otherwise.</returns>
        public static bool IsDecimal(TextBox textBox)
        {
            if (!decimal.TryParse(textBox.Text, out _))
            {
                MessageBox.Show($"{textBox.Tag} should be a decimal.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the given textbox contains a value within the given range.
        /// </summary>
        /// <param name="textBox">The textbox to be validated.</param>
        /// <param name="min">The minimum acceptable value.</param>
        /// <param name="max">The maximum acceptable value.</param>
        /// <returns>true if the textbox contains a value within the given range; false otherwise.</returns>
        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
        {
            decimal value = decimal.Parse(textBox.Text);
            if (value < min || value > max)
            {
                MessageBox.Show($"{textBox.Tag} should be between {min} and {max}.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the given textbox contains a string that matches the
        /// given pattern (a regurlar expression).
        /// </summary>
        /// <param name="textBox">The textbox to be validated.</param>
        /// <param name="pattern">The pattern with the regular expression.</param>
        /// <returns>true if the textbox contains a string matching the pattern; false otherwise.</returns>
        public static bool MatchesPattern(TextBox textBox, string pattern)
        {
            if (!Regex.IsMatch(textBox.Text, pattern))
            {
                MessageBox.Show($"{textBox.Tag} has an invalid format.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the given textbox contains a string of length within the given range.
        /// </summary>
        /// <param name="textBox">The textbox to be validated.</param>
        /// <param name="minLen">The minimum acceptable string length.</param>
        /// <param name="maxLen">The maximum acceptable string length.</param>
        /// <returns>true if the textbox contains a string with valid length; false otherwise</returns>
        public static bool IsWithinLength(TextBox textBox, int minLen, int maxLen)
        {
            string value = textBox.Text;
            if (value.Length < minLen || value.Length > maxLen)
            {
                MessageBox.Show($"The length of {textBox.Tag} should be between " +
                    $"{minLen} and {maxLen}.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the given combobox has selected data.
        /// </summary>
        /// <param name="comboBox">The combobox to be validated.</param>
        /// <returns>true if the combobox has selected data; false otherwise.</returns>
        public static bool IsSelected(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show($"{comboBox.Tag} should be selected.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox.Focus();
                return false;
            }
            return true;
        }

    }
}
