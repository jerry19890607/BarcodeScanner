# Barcode Scanner
 - It's the utility designed to scanning the 2D barcode and compare the sting whether the same or not.

## Configuration
 - Edit "DefaultPath.conf" to change the default log file (If conf not exist, will settting default path to C:\\barcodeLog\BarcodeLogFile.txt)

## Usage
 - Fill out your name or operator name
 - Choose Bank Name
 - Scan the 2D barcode by barcode scannner
 - The result shows on screen and log to the file (Default D:\\BarcodeLogFile.txt)
 - Export txt log to Excel format, lick export button, it will separate by comma (Default D:\\BarcodeLogFile.txt)

## Release
    - v1.0.3
        1. Edit default patch conf to change the default log file
        2. Add programe icon
        3. Publish version in one file in Bin

    - v1.0.2
        1. Clear text box if input is empty
        2. Implement txt export to Excel feature

    - v1.0.1
        1. Fix input null string bug
        2. Window re-size locked
        3. If log file not exist, create it!
        4. Implement log browser function
        5. Log file separate by ";"
        6. Enhancement of reset by space or enter key

    - v1.0.0
        * Init version

## Example:
 - Output true
![Correct 2D compare](./image/sample_true.jpg)

 - Output false
![Incorrect 2D compare](./image/sample_false.jpg)

 - Txt log file and export Excel
![Log file](./image/log.jpg)
