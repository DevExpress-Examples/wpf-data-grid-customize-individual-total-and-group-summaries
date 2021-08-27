<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653230/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4998)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [SimpleData.cs](./CS/DXSample/Data/SimpleData.cs) (VB: [SimpleData.vb](./VB/DXSample/Data/SimpleData.vb))
* [ViewModel.cs](./CS/DXSample/Data/ViewModel.cs) (VB: [ViewModel.vb](./VB/DXSample/Data/ViewModel.vb))
* [MainWindow.xaml](./CS/DXSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXSample/MainWindow.xaml))
<!-- default file list end -->
# How to style GridControl's summary items separately when summary items are aligned by columns


<p>Starting with <strong>v16.1</strong>, TableView provides the following properties, which allow you to style each GridControl's summary item separately:<br>1. <a href="https://documentation.devexpress.com/WPF/DevExpressXpfGridDataViewBase_FixedTotalSummaryElementStyletopic.aspx">FixedTotalSummaryElementStyle</a></p>
<p>2. <a href="https://documentation.devexpress.com/WPF/DevExpressXpfGridDataViewBase_TotalSummaryElementStyletopic.aspx">TotalSummaryElementStyle</a></p>
<p>3. <a href="https://documentation.devexpress.com/WPF/DevExpressXpfGridTableView_GroupColumnFooterElementStyletopic.aspx">GroupColumnFooterElementStyle</a></p>
<p>4. <a href="https://documentation.devexpress.com/WPF/DevExpressXpfGridGridViewBase_GroupColumnSummaryElementStyletopic.aspx">GroupColumnSummaryElementStyle</a></p>
<p><br><br>For versions <strong>15.2</strong> and older, when group summary items are aligned by columns, it is necessary to use the TableView's GroupColumnSummaryItemTemplate property to style GridControl group summary items. <br>The main idea of this approach is to define a custom ItemsControl inside the GroupColumnSummaryItemTemplate, bind its ItemsSource property to the collection of group summaries and show summary items as child ItemsControl elements. To customize summaries you can use ItemsControl properties, for instance, ItemTemplateSelector.<br><br></p>

<br/>


