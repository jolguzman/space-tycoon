using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

    // a SpriteRenderer that will be instantiated in a grid to create our board
    public Transform m_emptySprite;
    public bool m_display_grid;
    public int m_grid_segment_length;
    public int m_grid_segment_width;
    public int m_length;
    public int m_width;
    
    private int grid_x_position;
    private int grid_z_position;
	// Use this for initialization
	void Start () {
        grid_x_position = (int)this.transform.position.x;                   // gets te current x position of the grid
        grid_z_position = (int)this.transform.position.z;                   // gets the current z position of the grid
        draw_grid();
	}
	
	// Update is called once per frame
	void Update () {
        
	}


    // draws a grid outline on the plane
    private void draw_grid()
    {
		if (m_emptySprite)
		{
			for (int x = grid_x_position; x != grid_x_position - m_length ; x--)
			{
				for (int z = grid_z_position; z != grid_z_position - m_width; z--) 
				{
					Transform clone;
                    clone = Instantiate(m_emptySprite, new Vector3(x , 0, z), Quaternion.identity) as Transform;

					// names the empty squares for organizational purposes
					clone.name = "Board Space ( x = " + x.ToString() +  " , z =" + z.ToString() + " )";
                    // rotate empty square flat
                    clone.Rotate(90, 0, 0);
					// parents all of the empty squares to the Board object
					clone.transform.parent = transform;
				}
			}
		}
	}

}
