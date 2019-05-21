// Copyright Eric Chauvin 2018 - 2019.


/*

// For each triangle on the surface of the earth,
// make one vertical point above one triangle point
// and make a tetrahedron out of that.  Then put one
// more vertical point above the next triangle point
// and add a new vertex to that new point.  One
// Tetrahedron for each vertical point above
// each triangle point.

*/


using System;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Media.Imaging;

// For testing.
// using System.Windows.Forms;




namespace ClimateModel
{
  public class Tetrahedron
  {

/*
  private MeshGeometry3D MakeTetrahedron()
    {
    try
    {
    MeshGeometry3D Surface = new MeshGeometry3D();

    // TriStack1.Clear();

    TriangleStack.LatLongPosition PosRight = new TriangleStack.LatLongPosition();
    TriangleStack.LatLongPosition PosLeftTop = new TriangleStack.LatLongPosition();
    TriangleStack.LatLongPosition PosLeftBottom = new TriangleStack.LatLongPosition();
    TriangleStack.LatLongPosition PosNorthPole = new TriangleStack.LatLongPosition();
    TriangleStack.LatLongPosition PosSouthPole = new TriangleStack.LatLongPosition();
    TriangleStack.LatLongPosition PosFarEast = new TriangleStack.LatLongPosition();
    TriangleStack.LatLongPosition PosFarWest = new TriangleStack.LatLongPosition();

    // int Triangle Index 0
    PosRight.Latitude = -30.0;
    PosRight.Longitude = 0;
    TriangleStack.SetLatLonPositionXYZ( ref PosRight );

    PosLeftTop.Latitude = -30.0;
    PosLeftTop.Longitude = 120;
    TriangleStack.SetLatLonPositionXYZ( ref PosLeftTop );

    PosLeftBottom.Latitude = -30.0;
    PosLeftBottom.Longitude = -120;
    TriangleStack.SetLatLonPositionXYZ( ref PosLeftBottom );

    PosNorthPole.Latitude = 90.0;
    PosNorthPole.Longitude = 0;
    TriangleStack.SetLatLonPositionXYZ( ref PosNorthPole );

    PosSouthPole.Latitude = -90.0;
    PosSouthPole.Longitude = 0;
    TriangleStack.SetLatLonPositionXYZ( ref PosSouthPole );

    PosFarEast.Latitude = 30;
    PosFarEast.Longitude = 180;
    TriangleStack.SetLatLonPositionXYZ( ref PosFarEast );

    PosFarWest.Latitude = 30;
    PosFarWest.Longitude = -180;
    TriangleStack.SetLatLonPositionXYZ( ref PosFarWest );

    PosRight.Index = 0;
    AddSurfaceVertex( ref Surface, PosRight );
    PosLeftTop.Index = 1;
    AddSurfaceVertex( ref Surface, PosLeftTop );
    PosLeftBottom.Index = 2;
    AddSurfaceVertex( ref Surface, PosLeftBottom );
    PosNorthPole.Index = 3;
    AddSurfaceVertex( ref Surface, PosNorthPole );
    PosSouthPole.Index = 4;
    AddSurfaceVertex( ref Surface, PosSouthPole );

    PosFarEast.Index = 5;
    AddSurfaceVertex( ref Surface, PosFarEast );
    PosFarWest.Index = 6;
    AddSurfaceVertex( ref Surface, PosFarWest );


    // Counterclockwise winding:
    AddSurfaceTriangleIndex( ref Surface,
                    PosNorthPole.Index,
                    PosRight.Index,
                    PosLeftTop.Index );


//////////
    AddSurfaceTriangleIndex( ref Surface,
                    PosNorthPole.Index,
                    PosLeftTop.Index,
                    PosLeftBottom.Index );
////////////



    // PosLeftBottom.Longitude = -120;

    AddSurfaceTriangleIndex( ref Surface,
                    PosFarWest.Index,
                    PosLeftBottom.Index,
                    PosNorthPole.Index );


    AddSurfaceTriangleIndex( ref Surface,
                    PosNorthPole.Index,
                    PosLeftBottom.Index,
                    PosRight.Index );


    // Counterclockwise winding as seen from the
    // south.
    AddSurfaceTriangleIndex( ref Surface,
                    PosSouthPole.Index,
                    PosLeftTop.Index,
                    PosRight.Index );

    AddSurfaceTriangleIndex( ref Surface,
                    PosSouthPole.Index,
                    PosRight.Index,
                    PosLeftBottom.Index );

    AddSurfaceTriangleIndex( ref Surface,
                    PosSouthPole.Index,
                    PosLeftBottom.Index,
                    PosLeftTop.Index );

    return Surface;
    }
    catch( Exception Except )
      {
      MForm.ShowStatus( "Exception in PlanetSphere.MakeTetrahedron(): " + Except.Message );
      return null;
      }
    }
*/



  }
}

