using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Device.Location;
using Windows.Devices.Geolocation;
using Microsoft.Phone.Maps.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
namespace Fisheries
{
    public partial class Landing_site : PhoneApplicationPage
    {
        public Landing_site()
        {
            InitializeComponent();
            UpdateMap();

           
              

              
        }
        public void UpdateMap()
        {
         /*  Map drew = new Map();
           drew.Margin = new Thickness(-12, 0, 0, 0);
           drew.SetView(new GeoCoordinate(5.354683, 24.644135), 3.5D);
           drew.LandmarksEnabled = true;
           drew.PedestrianFeaturesEnabled = true;*/
           

         //  ContentPanel.Children.Add(drew);


            
          
            MapLayer MyLayer = new MapLayer();
            MyLayer.Add(Addpointer(5.354683, 124.644135));
            MyLayer.Add(Addpointer(5.354683, 24.644135));
            MyMap.Layers.Add(MyLayer);

          
        }
        public MapOverlay Addpointer(double lat , double longt)
        {
            //creating the grid
            Grid MyGrid = new Grid();
            MyGrid.RowDefinitions.Add(new RowDefinition());
            MyGrid.RowDefinitions.Add(new RowDefinition());
            MyGrid.Background = new SolidColorBrush(Colors.Transparent);


            //creating the rectangle supposed to enter the grid
            Rectangle MyRectangle = new Rectangle();
            MyRectangle.Fill = new SolidColorBrush(Colors.Blue);
            MyRectangle.Height = 20;
            MyRectangle.Width = 80;
            MyRectangle.SetValue(Grid.RowProperty, 0);
            MyRectangle.SetValue(Grid.ColumnProperty, 0);
          //  MyRectangle.TextInputStart = "here";


            //adding a rectangle to the grid

            MyGrid.Children.Add(MyRectangle);

            //Creating a Polygon
            Polygon MyPolygon = new Polygon();
            MyPolygon.Points.Add(new Point(2, 0));
            MyPolygon.Points.Add(new Point(22, 0));
            MyPolygon.Points.Add(new Point(2, 40));
            MyPolygon.Stroke = new SolidColorBrush(Colors.Blue);
            MyPolygon.Fill = new SolidColorBrush(Colors.Blue);
            MyPolygon.SetValue(Grid.RowProperty, 1);
            MyPolygon.SetValue(Grid.ColumnProperty, 0);

            //addding a new polygon to the grid

            //Creating a MapOverlay and adding the Grid to it.
            MapOverlay MyOverlay = new MapOverlay();
            MyOverlay.Content = MyGrid;

            MyGrid.Children.Add(MyPolygon);

            //setting the geolocation cordiante to work on some polygon to show on the map
            MyOverlay.GeoCoordinate = new GeoCoordinate(lat , longt);

            //this is where is set the position overlay to a specific location on the map
            MyOverlay.PositionOrigin = new Point(0, 0.5);

            //Creating a MapLayer and adding the MapOverlay to it
            return MyOverlay;
        }

        public class Restaurant
        {
            public GeoCoordinate Coordinate { get; set; }
            public string Address { get; set; }
            public string Name { get; set; }
        }

     
        
    }
}