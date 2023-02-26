# Temperature-analyze - WinForms application that analyzes temperature samples stored in .txt file

# Project description
Temperature Measurement Results Analyzer is a program designed to process data from temperature sensors. The program reads data from a text file, parses it to extract the numeric values of temperature measurements, and calculates some statistical parameters such as the mean value, variance, minimum and maximum. The program allows the user to save the calculated parameters to a text file and to visualize the differences between consecutive measurements using a Chart control. The appearance of the chart can be customized by the user, e.g., by turning off some data series, legends, or changing the color.

The program has a user-friendly interface, with a modern and aesthetically pleasing design. It handles errors gracefully, preventing crashes or unexpected behavior, and provides feedback to the user about the success or failure of operations. For example, it displays messages informing the user about the status of file operations, such as opening or saving a file.

To ensure smooth operation and prevent incorrect user input, some fields and functionalities are disabled until the required data is loaded or processed. For instance, the user cannot open the chart until the temperature data is loaded, and cannot save the calculated parameters until they are computed.

The program also provides additional features, such as the computation of a supplementary signal parameter or the display of a second data series on the chart. These features allow the user to extend the functionality of the program and customize it to their needs.
