using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePokemon : MonoBehaviour {

	public GameObject pokemonPrefab,skywalker,swordsman,pokemon,bb8,headshot,dota,dragonman,chari,charm,chicken;
	public int not_born;
	void Start () {
		pokemonPrefab = Resources.Load ("charm") as GameObject;
		skywalker = Resources.Load ("silly_dancing") as GameObject;
		swordsman = Resources.Load ("Running_swordsman") as GameObject;
		pokemon = Resources.Load ("jumping") as GameObject;
		bb8 = Resources.Load ("BB8-Anim") as GameObject;
		headshot = Resources.Load ("Headshot_final 1") as GameObject;
		dota = Resources.Load ("POSE") as GameObject;
		dragonman = Resources.Load ("dragonman2") as GameObject;
		chari = Resources.Load ("dragon_cub") as GameObject;
		chicken = Resources.Load ("chicken") as GameObject;
		not_born = Random.Range(1,9) ;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (not_born==1) {
				pokemon = Instantiate (pokemonPrefab) as GameObject;
				not_born = 0;
			}
			if (not_born==2) {
				pokemon = Instantiate (skywalker) as GameObject;
				not_born = 0;
			}
			if (not_born==3) {
				pokemon = Instantiate (swordsman) as GameObject;
				not_born = 0;
			}
			if (not_born==4) {
				pokemon = Instantiate (pokemon) as GameObject;
				not_born = 0;
			}
			if (not_born==5) {
				pokemon = Instantiate (bb8) as GameObject;
				not_born = 0;
			}
			if (not_born==6) {
				pokemon = Instantiate (headshot) as GameObject;
				not_born = 0;
			}
			if (not_born==7) {
				pokemon = Instantiate (dragonman) as GameObject;
				not_born = 0;
			}
			if (not_born==8) {
				pokemon = Instantiate (chari) as GameObject;
				not_born = 0;
			}
			if (not_born==9) {
				pokemon = Instantiate (chicken) as GameObject;
				not_born = 0;
			}
			
		}
	}

}
