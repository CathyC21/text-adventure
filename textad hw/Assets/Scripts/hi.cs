using UnityEngine;
using System.Collections;

public class hi : MonoBehaviour {

	// Use this for initialization
	public string room = "entry"; 
	[Header("rooms")]
	public string art_room;
	public string lit_room; 
	public string math_room;
	public string music_room;
	public string sci_room;
	public string homec_room;
	public string hist_room;
	public string fac_room;
	public string lang_room;
	public string home_room;
	public string r_room;
	public string scikey_room;
	public string relit_room;
	public string tran_room;
	public string reart_room;

	[Header("Music")]
	public AudioSource bgm;
	public AudioClip bgm_win;

	public AudioSource sfx;
	public AudioClip sfx_bookf; 
	public AudioClip sfx_paper;

	private bool pikOut = false;
	private bool fall = false;
	private bool roomEnter = false;
//	private bool won = false;
	//private bool monster = false;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "";
	
		art_room = "";
		lit_room = ""; 
		math_room = "";
		music_room = "";
		sci_room = "";
		homec_room = "";
		hist_room = "";
		fac_room = "";
		lang_room = "";
		home_room = "";
		r_room = "";
		scikey_room = "";
		relit_room = "";
		tran_room = "";
		reart_room = "";
		
		switch (room) {
		case "entry":
			textBuffer = "Welcome to Hell\n" +
				"You must get to the Home Room...\n" +
					"Choose your rooms wisely.";
	
				art_room = "Art Room"; 


			break;
		case "Art Room":
			textBuffer = "Nothing seems to be the problem in the Art Room...yet..\n" +
				"lets move onto the next room..."; 
			lit_room = "Literature Room";
			break;
			
		case "Literature Room":
			textBuffer = "Bang! Tons of book just fell in front of you.\n" +
				"You have entered the Literature Room. \n" +
					"You must quickly put the books in the shelves.\n"+
				"Press 'd' when you're done\n" +
				"If you choose to ignore this task, press 'i'.";
			homec_room = "Home Ec"; 
			sci_room = "Science Room";
			if(!fall)
			{
				fall = true;
				sfx.clip = sfx_bookf;
				sfx.Play();
			}
		
			break;
		case "Home Ec":
			textBuffer = "You're in the Home Ec classroom.\n" +
				"Crap! Something shut the door! \n" +
				"Look for something to pick the lock. Press 'l' to do so.\n" +
				"There's utensils lying around, but it's dark so\n" + 
				"Be careful";
			
			if (Input.GetKeyDown (KeyCode.L)) {
				room = "got lock";
			}
			break;
		case "got lock":
			textBuffer = "Congrats!! You found a small fork \n" +
				"and used your phone as light. \n" +
				"In fear of this happening again,\n" +
				"you decide to take a small knife with you.";
			if(!pikOut)
			{
				pikOut = true;
				sfx.clip = sfx_paper;
				sfx.Play();
			}

			hist_room = "History Room";
			
			break;
			
		case "Science Room":
			
			textBuffer = "This is the Science Room.\n" +
				"Nothing out of the ordinary minus some creepy figures...";
			math_room = "Math Room";
			
			break;
		case "Math Room":
			textBuffer = "You need a key to get into this room.\n" +
				"It must be in the Science Room somewhere.\n" +
				"Press 'h' to go back..."; 
				if(Input.GetKeyDown(KeyCode.H))
			{
			scikey_room = "Science Room Key";
			}
			break;
		case "Science Room Key":
			textBuffer = "The key isn't here. In fact, there is no key.\n"+
				"You must find something to pry it open...\n"+
				"Was there something in the unknown room you passed by?\n"+
				"Maybe you should go back and pick up those books\n"+
				"from the Literature Room...\n"+
				"Press 'v' to go back to the room."; 
				
			homec_room = "Home Ec"; 
			relit_room = "Lit Room";

			break;
		case "Lit Room":
			textBuffer = " Now pick up those books.\n"+
				"Press 'd' when you're done.";
			homec_room = "Home Ec";

			break;
		case "History Room":
			
			textBuffer = "Ah the History Room... \n" +
				"There seems to be something behind the \n" +
				"George Washington poster... \n" +
				"It's a hint to the next room!\n" +
				"Press 'y' to see what it is...";
			if (Input.GetKeyDown (KeyCode.Y)) {
				r_room = "Hint";
			}
			
			break;
		case "Hint":
			textBuffer = "It says... \n" +
				" 'Lots of tests... authority... and gossip!\n" +
				"Which room can it be...?";
			lang_room = "Language Room";
			fac_room = "Faculty Room";
			music_room = "Music Room"; 
			break;
			
			
		case "Music Room":
			//if (pikOut) {
			textBuffer = "What's this sound?! There's the sound of the piano\n" +
				"but no one is playing!!! And the door is locked! Use your knife!\n" +
					"It looks like the next room will be the end to this madness..."+
					"Press 'b' to see...";

			home_room = "Home Room"; 

			
			break; 
		case "Language Room":
			textBuffer = "This is the Language Room... English, Spanish, you name it.\n"+
				"There's something written on the board but it's in Italian.\n"+
				"Thankfully, there's a little light and a dictionary on the floor.\n"+
					"Press 'm' to search for a translation.";

				tran_room = "Translated";

			break;
		case "Translated":
			textBuffer = "You found it! It says... 'You chose the wrong room...'\n"+
				"Hurry leave before something happens\n"+
				"press 'y' to go back";
			r_room = "Hint";
			break;
		case "Faculty Room":
			textBuffer = "Faculty Room! It must be because it reeks of authority.\n"+
				"This room connects directly to somewhere... \n"+
			    "Press 'f' to see...";
			reart_room = "Re Art Room";
			break;
		case "Re Art Room":
			textBuffer = "That hint was a fake!!! Darn! \n"+
				"You're back to where you started!!! D: Bad choice..."; 

			lit_room = "Literature Room"; 
			break;

		case "Home Room":

			
			textBuffer = "You made it!!! You're safe in the Home Room. What a journey... \n"+
				"Celebrate your victory with homework in a cozy classroom\n"+
					"With a cup of hot chocolate. :) Cheers"; 
			break;

		default:
			break;
		}
		/*

		art_room = "";
		lit_room = ""; 
		math_room = "";
		music_room = "";
		sci_room = "";
		homec_room = "";
		hist_room = "";
		fac_room = "";
		lang_room = "";
		home_room = "";
		r_room = "";
*/

		if (art_room != "") 
		{
			textBuffer += "\nPress 'q' to begin your journey at the " + art_room + ".";
			if (Input.GetKeyDown (KeyCode.Q)) {
				room = art_room;
			}
			roomEnter = false;
		}

		if (lit_room != "") 
		{

			textBuffer += "\nPress 'w' to go to the " + lit_room + ".";
			if (Input.GetKeyDown (KeyCode.W)) {
				
				room = lit_room;
			}

			roomEnter = false;
		}
		if (sci_room != "") 
		{
			if (Input.GetKeyDown (KeyCode.I)) {
				room = sci_room;
		}
			roomEnter = false;
		}
		if (homec_room != "") 
		{
			if (Input.GetKeyDown (KeyCode.D)) {
				room = homec_room;
			}
			roomEnter = false;
		}

		if (scikey_room != "") 

		{
			if(Input.GetKeyDown (KeyCode.H))
			{
				room = scikey_room;
			}
			if(Input.GetKeyDown (KeyCode.V))
			{
				room = lit_room;
			}
			roomEnter = false;
		}
		if (relit_room != "") 
		{
			if(Input.GetKeyDown (KeyCode.V))
			{
				room = relit_room;
			}
		}
		
		if (math_room != "") 
		{
			textBuffer += "\nPress 'e' to go to the " + math_room + ".";
			if (Input.GetKeyDown (KeyCode.E)) {
				
				room = math_room;
			}
			roomEnter = false;
		}
		if (music_room != "") 
		{
			textBuffer += "\nPress 'r' to go to the " + music_room + ".";
			if (Input.GetKeyDown (KeyCode.R))
			{
				
				room = music_room;
			}
			roomEnter = false;
		}
		if (hist_room != "") 
		{
			textBuffer += "\nPress 't' to go to the " + hist_room + ".";
			if (Input.GetKeyDown (KeyCode.T)) 
			{
				
				room = hist_room;
			}
			roomEnter = false;
		}
		if (r_room != "") 
		{
			if(Input.GetKeyDown (KeyCode.Y))
			{
				room = r_room;
			}
			roomEnter = false;
		}
	
		if (lang_room != "") 
		{
			textBuffer += "\nPress 'z' to go to the " + lang_room + ".";
			if (Input.GetKeyDown (KeyCode.Z))
			{

				room = lang_room;
			}
			roomEnter = false;
		}
		if (fac_room != "") 
		{
			textBuffer += "\nPress 'x' to go to the " + fac_room + ".";
			if (Input.GetKeyDown (KeyCode.X))
			{
				
				room = fac_room;
			}
			roomEnter = false;		
		}
		if (tran_room != "") 
		{

			if (Input.GetKeyDown (KeyCode.M))
			{
				
				room = tran_room;
			}
			roomEnter = false;
		}
		if (reart_room != "")
		{
			if(Input.GetKeyDown(KeyCode.F))
			{
				room = reart_room;
			}
		}
		if (home_room != "") 
		{
			if(Input.GetKeyDown(KeyCode.B))
			{
				room = home_room;
			}
			roomEnter = false;
		}
		GetComponent<TextMesh>().text = textBuffer;
		
	}
	
}