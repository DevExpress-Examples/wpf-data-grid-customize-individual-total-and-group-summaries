<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653230/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4998)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
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


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-customize-individual-total-and-group-summaries&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-customize-individual-total-and-group-summaries&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
