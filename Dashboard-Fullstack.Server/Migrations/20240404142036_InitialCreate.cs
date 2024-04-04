using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dashboard_Fullstack.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IAxisOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reversed = table.Column<bool>(type: "bit", nullable: true),
                    Opposite = table.Column<bool>(type: "bit", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: true),
                    Min = table.Column<double>(type: "float", nullable: true),
                    Max = table.Column<double>(type: "float", nullable: true),
                    TickInterval = table.Column<double>(type: "float", nullable: true),
                    LabelsEnabled = table.Column<bool>(type: "bit", nullable: true),
                    GridLinesEnabled = table.Column<bool>(type: "bit", nullable: true),
                    PlotLinesEnabled = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IAxisOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IButtonOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enabled = table.Column<bool>(type: "bit", nullable: true),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IButtonOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IInteractionOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZoomType = table.Column<bool>(type: "bit", nullable: true),
                    Pan = table.Column<bool>(type: "bit", nullable: true),
                    Selection = table.Column<bool>(type: "bit", nullable: true),
                    Crosshair = table.Column<bool>(type: "bit", nullable: true),
                    Trackball = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IInteractionOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ILegendOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enabled = table.Column<bool>(type: "bit", nullable: true),
                    Layout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Align = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerticalAlign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    Padding = table.Column<double>(type: "float", nullable: true),
                    ItemDistance = table.Column<double>(type: "float", nullable: true),
                    ItemStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemHoverStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SymbolPadding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SymbolWidth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SymbolHeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ILegendOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ISeriesOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Visible = table.Column<bool>(type: "bit", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DashStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LineWidth = table.Column<double>(type: "float", nullable: true),
                    MarkerRadius = table.Column<double>(type: "float", nullable: true),
                    MarkerSymbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnableMouseTracking = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISeriesOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IStyleOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FontFamily = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FontWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FontStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderRadius = table.Column<double>(type: "float", nullable: true),
                    BorderWidth = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IStyleOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ISubtitleOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Align = table.Column<bool>(type: "bit", nullable: true),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floating = table.Column<bool>(type: "bit", nullable: true),
                    Margin = table.Column<double>(type: "float", nullable: true),
                    WidthAdjust = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISubtitleOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ITitleOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Align = table.Column<bool>(type: "bit", nullable: true),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floating = table.Column<bool>(type: "bit", nullable: true),
                    Margin = table.Column<double>(type: "float", nullable: true),
                    WidthAdjust = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITitleOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ITooltipOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PointFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueSuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValuePrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shared = table.Column<bool>(type: "bit", nullable: true),
                    Crosshairs = table.Column<bool>(type: "bit", nullable: true),
                    Split = table.Column<bool>(type: "bit", nullable: true),
                    XOffset = table.Column<double>(type: "float", nullable: true),
                    YOffset = table.Column<double>(type: "float", nullable: true),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITooltipOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidgetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Widgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DashboardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widgets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Widgets_Dashboards_DashboardId",
                        column: x => x.DashboardId,
                        principalTable: "Dashboards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IPlotLine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: true),
                    DashStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<double>(type: "float", nullable: true),
                    LabelText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IAxisOptionsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPlotLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPlotLine_IAxisOptions_IAxisOptionsId",
                        column: x => x.IAxisOptionsId,
                        principalTable: "IAxisOptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "INavigationOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enabled = table.Column<bool>(type: "bit", nullable: true),
                    ButtonOptionsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INavigationOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_INavigationOptions_IButtonOptions_ButtonOptionsId",
                        column: x => x.ButtonOptionsId,
                        principalTable: "IButtonOptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChartOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    XAxisId = table.Column<int>(type: "int", nullable: true),
                    YAxisId = table.Column<int>(type: "int", nullable: true),
                    TitleId = table.Column<int>(type: "int", nullable: true),
                    SubtitleId = table.Column<int>(type: "int", nullable: true),
                    LegendId = table.Column<int>(type: "int", nullable: true),
                    NavigationId = table.Column<int>(type: "int", nullable: true),
                    TooltipId = table.Column<int>(type: "int", nullable: true),
                    InteractionId = table.Column<int>(type: "int", nullable: true),
                    StyleId = table.Column<int>(type: "int", nullable: true),
                    SeriesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChartOptions_IAxisOptions_XAxisId",
                        column: x => x.XAxisId,
                        principalTable: "IAxisOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChartOptions_IAxisOptions_YAxisId",
                        column: x => x.YAxisId,
                        principalTable: "IAxisOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChartOptions_IInteractionOptions_InteractionId",
                        column: x => x.InteractionId,
                        principalTable: "IInteractionOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChartOptions_ILegendOptions_LegendId",
                        column: x => x.LegendId,
                        principalTable: "ILegendOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChartOptions_INavigationOptions_NavigationId",
                        column: x => x.NavigationId,
                        principalTable: "INavigationOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChartOptions_ISeriesOptions_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "ISeriesOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChartOptions_IStyleOptions_StyleId",
                        column: x => x.StyleId,
                        principalTable: "IStyleOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChartOptions_ISubtitleOptions_SubtitleId",
                        column: x => x.SubtitleId,
                        principalTable: "ISubtitleOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChartOptions_ITitleOptions_TitleId",
                        column: x => x.TitleId,
                        principalTable: "ITitleOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChartOptions_ITooltipOptions_TooltipId",
                        column: x => x.TooltipId,
                        principalTable: "ITooltipOptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Datas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Headers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Labels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Datas_ChartOptions_OptionsId",
                        column: x => x.OptionsId,
                        principalTable: "ChartOptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DataSeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSeries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataSeries_Datas_DataId",
                        column: x => x.DataId,
                        principalTable: "Datas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Private = table.Column<bool>(type: "bit", nullable: false),
                    ElementType = table.Column<int>(type: "int", nullable: false),
                    DataId = table.Column<int>(type: "int", nullable: true),
                    WidgetId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Elements_Datas_DataId",
                        column: x => x.DataId,
                        principalTable: "Datas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Elements_Widgets_WidgetId",
                        column: x => x.WidgetId,
                        principalTable: "Widgets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Row",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Values = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Row", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Row_Datas_DataId",
                        column: x => x.DataId,
                        principalTable: "Datas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChartOptions_InteractionId",
                table: "ChartOptions",
                column: "InteractionId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartOptions_LegendId",
                table: "ChartOptions",
                column: "LegendId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartOptions_NavigationId",
                table: "ChartOptions",
                column: "NavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartOptions_SeriesId",
                table: "ChartOptions",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartOptions_StyleId",
                table: "ChartOptions",
                column: "StyleId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartOptions_SubtitleId",
                table: "ChartOptions",
                column: "SubtitleId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartOptions_TitleId",
                table: "ChartOptions",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartOptions_TooltipId",
                table: "ChartOptions",
                column: "TooltipId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartOptions_XAxisId",
                table: "ChartOptions",
                column: "XAxisId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartOptions_YAxisId",
                table: "ChartOptions",
                column: "YAxisId");

            migrationBuilder.CreateIndex(
                name: "IX_Datas_OptionsId",
                table: "Datas",
                column: "OptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSeries_DataId",
                table: "DataSeries",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_Elements_DataId",
                table: "Elements",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_Elements_WidgetId",
                table: "Elements",
                column: "WidgetId");

            migrationBuilder.CreateIndex(
                name: "IX_INavigationOptions_ButtonOptionsId",
                table: "INavigationOptions",
                column: "ButtonOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_IPlotLine_IAxisOptionsId",
                table: "IPlotLine",
                column: "IAxisOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Row_DataId",
                table: "Row",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_Widgets_DashboardId",
                table: "Widgets",
                column: "DashboardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataSeries");

            migrationBuilder.DropTable(
                name: "Elements");

            migrationBuilder.DropTable(
                name: "IPlotLine");

            migrationBuilder.DropTable(
                name: "Row");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Widgets");

            migrationBuilder.DropTable(
                name: "Datas");

            migrationBuilder.DropTable(
                name: "Dashboards");

            migrationBuilder.DropTable(
                name: "ChartOptions");

            migrationBuilder.DropTable(
                name: "IAxisOptions");

            migrationBuilder.DropTable(
                name: "IInteractionOptions");

            migrationBuilder.DropTable(
                name: "ILegendOptions");

            migrationBuilder.DropTable(
                name: "INavigationOptions");

            migrationBuilder.DropTable(
                name: "ISeriesOptions");

            migrationBuilder.DropTable(
                name: "IStyleOptions");

            migrationBuilder.DropTable(
                name: "ISubtitleOptions");

            migrationBuilder.DropTable(
                name: "ITitleOptions");

            migrationBuilder.DropTable(
                name: "ITooltipOptions");

            migrationBuilder.DropTable(
                name: "IButtonOptions");
        }
    }
}
