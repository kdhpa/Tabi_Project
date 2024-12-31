using UnityEngine;

public class PysicsObject : MonoBehaviour
{
	[Header("¹°¸® Draw Property")]
	public Vector2 collider_size;
	public bool is_always_draw_gizmo = false;

	public float mass;
	public float bounce;

	public float gravity = 0.98f;

	protected Vector3 next_position = Vector3.zero;

	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		next_position = transform.position;
		next_position.y = next_position.y - gravity;
		update();
	}

	public virtual void update()
	{

	}

	public virtual void Collision()
	{

	}

	public void DrawColliderGizmo()
	{
		Gizmos.color = Color.green;
		Vector2 position = transform.position;
		float x = position.x;
		float y = position.y;

		float x_left = x - (collider_size.x / 2);
		float x_right = x + (collider_size.x / 2);
		float y_down = y - (collider_size.y / 2);
		float y_up = y + (collider_size.y / 2);

		Gizmos.DrawLine(new Vector2(x_left, y_down), new Vector2(x_left, y_up));
		Gizmos.DrawLine(new Vector2(x_right, y_down), new Vector2(x_right, y_up));
		Gizmos.DrawLine(new Vector2(x_left, y_up), new Vector2(x_right, y_up));
		Gizmos.DrawLine(new Vector2(x_left, y_down), new Vector2(x_right, y_down));
	}

	public void OnDrawGizmos()
	{
		if (is_always_draw_gizmo)
		{
			DrawColliderGizmo();
		}
	}

	public void OnDrawGizmosSelected()
	{
		DrawColliderGizmo();
	}
}
