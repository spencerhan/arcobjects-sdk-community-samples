##Time Series Graph tool add-in

###Purpose  
The Time Series Graph tool builds a line graph from a point feature layer according to different time values. The layer contains multiple measurements for a set of seven gages. Each measurement has its own stream flow value, date and time, and gage ID attributes associated with it. When you click a feature point (gage station) using the Time Series Graph tool, the tool identifies the point and finds the gage ID. All the measurements from this point for this gage ID are used in making a graph based on a graph template. If there is an existing open graph window, the tool creates the graph series in this window. If there is no open graph window, the tool creates the graph series in a new graph window.   


###Usage
1. Open the solution file in Visual Studio and build the project.   
1. Start ArcMap, click the Customize drop-down menu, and click Customize Mode. The Customize dialog box appears.  
1. Click the Commands tab, scroll to Add-in Controls in the categories list, and drag the Time Series Graph tool to a toolbar in ArcMap.   
1. Move the timeseries.tee file from the sample folder to the <your ArcGIS for Desktop install location>/GraphTemplates folder.  
1. Add the TimeSerTool.lyr to ArcMap.   
1. Select the Time Series Graph tool and click the point (gage station). A line graph is drawn in a new graph window.   
1. To add lines to the same graph, keep the graph window open, and a new line is added into it. To draw lines on a new graph, close the graph window, and a new line is drawn in a separate graph window.   









---------------------------------

####Licensing  
| Development licensing | Deployment licensing | 
| :------------- | :------------- | 
| ArcGIS for Desktop Basic | ArcGIS for Desktop Basic |  
| ArcGIS for Desktop Standard | ArcGIS for Desktop Standard |  
| ArcGIS for Desktop Advanced | ArcGIS for Desktop Advanced |  

