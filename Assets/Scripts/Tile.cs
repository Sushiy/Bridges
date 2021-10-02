using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public enum TileType
    {
        Woods,
        Meadow,
        Street,
        House
    }

    public Climbpoint root;

    private void OnDrawGizmos()
    {
        if(root != null)
        {
            root.Draw(this);
        }
    }

    [System.Serializable]
    public class Climbpoint
    {
        public Tile tile;
        public Climbpoint parent;
        public List<Climbpoint> children;

        public Vector3 localPosition;

        public Climbpoint(Tile t, Climbpoint parent)
        {
            this.tile = t;
            this.parent = parent;
            children = new List<Climbpoint>();
        }

        public Vector3 Position
        {
            get
            {
                return tile.transform.TransformPoint(localPosition);
            }
        }

        public void Draw(Tile t)
        {
            if (tile == null)
                tile = t;
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(Position, new Vector3(0.2f,0.2f,0.2f));
            for(int i = 0; i < children.Count; i++)
            {
                Gizmos.DrawLine(Position, children[i].Position);
                children[i].Draw(t);
            }
        }

    }
}
