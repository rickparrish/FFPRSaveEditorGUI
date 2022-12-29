using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFPRSaveEditorGUI {
    internal class Helpers {
        public static int GetInt(string prompt, string title, int value, int min = 0, int max = int.MaxValue) {
            while (true) {
                string response = Interaction.InputBox(prompt, title, value.ToString());

                // Remove thousands separator to avoid validation errors if they type something like 123,456
                response = response.Replace(Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberGroupSeparator, "");

                if (string.IsNullOrWhiteSpace(response)) {
                    // User cancelled, so return the original value
                    return value;
                } else if (int.TryParse(response, out int result)) {
                    if (result < min) {
                        MessageBox.Show($"New value must be greater than or equal to {min}", "New value is too small", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else if (result > max) {
                        MessageBox.Show($"New value must be less than or equal to {max}", "New value is too large", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        return result;
                    }
                } else {
                    MessageBox.Show($"New value must be a number between {min} and {max}", "New value is not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static string GetString(string prompt, string title, string value) {
            while (true) {
                string response = Interaction.InputBox(prompt, title, value);
                if (string.IsNullOrWhiteSpace(response)) {
                    // User cancelled, so return the original value
                    return value;
                } else {
                    return response;
                }
            }
        }

        public static string SecToHMS(decimal playTime) {
            int hours = Convert.ToInt32(Math.Floor(playTime / 3600));
            playTime -= hours * 3600;

            int minutes = Convert.ToInt32(Math.Floor(playTime / 60));
            playTime -= minutes * 60;

            int seconds = Convert.ToInt32(playTime);

            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
    }
}
