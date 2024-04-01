using System.ComponentModel.DataAnnotations;

namespace Dashboard_Fullstack.Server.Models;

public class Dashboard
{
    public required string Name { get; set; }
    public required string Organization { get; set; }
    public required int Id { get; set; }
    public ICollection<Widget> Widgets { get; set; }
}

public class Widget
{
    public required string Name { get; set; }
    public required string Position { get; set; }
    public ICollection<Element> Elements { get; set; }
    public required int Id { get; set; }
}

public class Element
{
    public required int Id { get; set; }
    public bool Private { get; set; } = false;
    public required ElementType ElementType { get; set; }
    public Data? Data { get; set; }
}

public enum ElementType
{
    None,
    Text,
    Line,
    Spline,
    Area,
    AreaSpline,
    Column,
    Bar,
    Pie,
    Scatter,
    Bubble,
    WindRose,
    BoxPlot,
    Table,
    Image,
    Dropdown,
    Checkbox,
    Radio,
    CustomHTML,
    Kpi
}

public class Data
{
    public required int Id { get; set; }
    public string? Name { get; set; }
    public string? TextValue { get; set; }
    public int? Value { get; set; }
    public string[]? Headers { get; set; }
    public ICollection<Row> Rows { get; set; }
    public string[]? Labels { get; set; }
    public DataSeries[]? Series { get; set; }
}

public class Row
{
    public int Id { get; set; }
    public string[] Values { get; set; }
}

public class Chart
{
    public string Type { get; set; }
    public string Title { get; set; }
    public string Subtitle { get; set; }
    public string[] Categories { get; set; }
    public ChartOptions? Options { get; set; }
}

public class DataSeries
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double[] Data { get; set; }
}

public class ChartOptions
{
    public IAxisOptions XAxis { get; set; }
    public IAxisOptions YAxis { get; set; }
    public ITitleOptions Title { get; set; }
    public ISubtitleOptions Subtitle { get; set; }
    public ILegendOptions Legend { get; set; }
    public INavigationOptions Navigation { get; set; }
    public ITooltipOptions Tooltip { get; set; }
    public IInteractionOptions Interaction { get; set; }
    public IStyleOptions Style { get; set; }
    public IAnimationOptions Animation { get; set; }
    public ISeriesOptions Series { get; set; }
}

public interface IAxisOptions
{
    public string Title { get; set; }
    public string[] Categories { get; set; }
    public bool? Reversed { get; set; }
    public bool? Opposite { get; set; }
    public bool? Visible { get; set; }
    public double? Min { get; set; }
    public double? Max { get; set; }
    public double? TickInterval { get; set; }
    public bool? LabelsEnabled { get; set; }
    public bool? GridLinesEnabled { get; set; }
    public bool? PlotLinesEnabled { get; set; }
    public IPlotLine[] PlotLines { get; set; }
}

public interface IPlotLine
{
    public string Color { get; set; }
    public double? Value { get; set; }
    public string DashStyle { get; set; }
    public double? Width { get; set; }
    public string LabelText { get; set; }
}

public interface ITitleOptions
{
    public string Text { get; set; }
    public bool? Align { get; set; }
    public string Style { get; set; }
    public bool? Floating { get; set; }
    public double? Margin { get; set; }
    public double? WidthAdjust { get; set; }
}

public interface ISubtitleOptions
{
    public string Text { get; set; }
    public bool? Align { get; set; }
    public string Style { get; set; }
    public bool? Floating { get; set; }
    public double? Margin { get; set; }
    public double? WidthAdjust { get; set; }
}

public interface ILegendOptions
{
    public bool? Enabled { get; set; }
    public string Layout { get; set; }
    public string Align { get; set; }
    public string VerticalAlign { get; set; }
    public double? X { get; set; }
    public double? Y { get; set; }
    public double? Padding { get; set; }
    public double? ItemDistance { get; set; }
    public string ItemStyle { get; set; }
    public string ItemHoverStyle { get; set; }
    public string SymbolPadding { get; set; }
    public string SymbolWidth { get; set; }
    public string SymbolHeight { get; set; }
}

public interface INavigationOptions
{
    public bool? Enabled { get; set; }
    public IButtonOptions ButtonOptions { get; set; }
}

public interface IButtonOptions
{
    public bool? Enabled { get; set; }
    public string Theme { get; set; }
}

public interface ITooltipOptions
{
    public string HeaderFormat { get; set; }
    public string PointFormat { get; set; }
    public string FooterFormat { get; set; }
    public string ValueSuffix { get; set; }
    public string ValuePrefix { get; set; }
    public bool? Shared { get; set; }
    public bool? Crosshairs { get; set; }
    public bool? Split { get; set; }
    public double? XOffset { get; set; }
    public double? YOffset { get; set; }
    public string Style { get; set; }
}

public interface IInteractionOptions
{
    public bool? ZoomType { get; set; }
    public bool? Pan { get; set; }
    public bool? Selection { get; set; }
    public bool? Crosshair { get; set; }
    public bool? Trackball { get; set; }
}

public interface IStyleOptions
{
    public string Color { get; set; }
    public string FontFamily { get; set; }
    public string FontWeight { get; set; }
    public string FontStyle { get; set; }
    public string BackgroundColor { get; set; }
    public string BorderColor { get; set; }
    public double? BorderRadius { get; set; }
    public double? BorderWidth { get; set; }
}

public interface IAnimationOptions
{
    public bool? Enabled { get; set; }
    public int? Duration { get; set; }
    public string Easing { get; set; }
}

public interface ISeriesOptions
{
    public bool? Visible { get; set; }
    public string Color { get; set; }
    public string DashStyle { get; set; }
    public double? LineWidth { get; set; }
    public double? MarkerRadius { get; set; }
    public string MarkerSymbol { get; set; }
    public bool? EnableMouseTracking { get; set; }
}