# Search the Icons (Images) that comes with the OpenFlows software

The tool allows to search/filter for the icons using keywords. 
It supports ([WaterGEMS](https://www.bentley.com/en/products/product-line/hydraulics-and-hydrology-software/watergems)/[WaterCAD](https://www.bentley.com/en/products/product-line/hydraulics-and-hydrology-software/watercad)/WaterOPW).
Technically, it should work with all the OpenFlows software.

## Download

Make sure to download the right version of the application. The OpenFlows-Water (OFW) is relative new API, so newer version of Water products are currently supported

### [Download v10.4.x.x](OFW.IsolationValveAdder/_setup.bat)

## Setup (Must Do!)

After extracting the contents from the compressed file, paste them over to the installation directory (typically: `C:\Program Files (x86)\Bentley\WaterGEMS\x64`).

## How to run

Open up the `OF.IconBrowser.exe` and screen like below loads.
Once the windows loads, either search a keyword or scan through the list.

![icon_browser_form](https://github.com/worthapenny/OpenFlows-IconBrowser/blob/main/Images/IconBrowser_Form.png "Icon Browser Form")


## Usage

Provide `Icon` or `Image` to the UI like below:
```csharp
this.Icon = (Icon)GraphicResourceManager.Current[StandardGraphicResourceNames.IconView];
this.Image = ((Icon)GraphicResourceManager.Current[StandardGraphicResourceNames.IconView]).ToBitmap();
```

## Other projects based on OpenFlows Water and/or WaterObjects.NET

* [Isolation Valve Adder](https://github.com/worthapenny/OpenFlows-Water--IsolationValveAdder)
* [Bing Background Adder](https://github.com/worthapenny/OpenFlows-Water--BingBackground)
* [Model Merger](https://github.com/worthapenny/OpenFlows-Water--ModelMerger)
* [Demand to CustomerMeter](https://github.com/worthapenny/OpenFlows-Water--DemandToCustomerMeter)
* [Icon Browser](https://github.com/worthapenny/OpenFlows-IconBrowser)

## Did you know?

Now, you can work with Bentley Water products with python as well. Check out:

* [Github pyofw](https://github.com/worthapenny/pyofw)
* [PyPI pyofw](https://pypi.org/project/pyofw/)

![pypi-image](https://github.com/worthapenny/OpenFlows-Water--ModelMerger/blob/main/images/pypi_pyofw.png "pyOFW module on pypi.org")
pi-image](https://github.com/worthapenny/OpenFlows-Water--ModelMerger/blob/main/images/pypi_pyofw.png "pyOFW module on pypi.org")