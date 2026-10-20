# Level Design
### ATTENTION !!! Level Design =/= level design
![Level Design =/= level design](imgs/level_design.png)

### Sources :
Livre de Level Design avec des liens vers d'autres ressources : https://book.leveldesignbook.com/

## Consigne de bon Level Design :

**A éviter :**
1. **Faire un layout trop "blocky" :** généralement l'erreur du débutant, des couloirs droits pas intéressants, des blocs placés ici et là.\
***Solution :*** un layout plus organique, prendre exemple sur la réalité. Peut avoir des couloirs mais faut les rendre intéressant et pas trop longs
2. 


## Le level design du jeu

### **Pre-production :**
*What* are you making?
- What will the player be able to do? (Mechanics, Experience Goals, Pacing) => voir [les fonctionnalités de la 1.0](ROADMAP.md)
- Which parts are most important? (Pillars) :
    - Histoire et Lore => jeu narratif donc **HYPER IMPORTANT**
    - Pathfinding => nécessite un bon level design
    - Environnement Art => je veux un jeu contemplatif aussi

*How* are you going to make this?
- How did other people solve similar problems? (Research) :\
    **=> Recherches à faire**

- How much time do you need? Is this feasible? (Scope) :\
    J'ai jusqu'à Septembre 2027 pour créer un jeu jouable et qui correspond à ma vision. Je pense que c'est faisable d'avoir au moins 2-3 chapitres de 3-4 niveaux

### **Project planning**

### Minimal Checklist

**Elevator pitch :** Describe the core concept and what makes it interesting. 1-2 sentences.

    Ce jeu est un jeu solo narratif de livraison de cargaisons qui se déroule dans un univers sci-fi/cyberpunk. Le joueur incarne un robot de livraison et explore la ville dans un système de path-finding.


**Tools :** What engine and tools will you use? Will they work for this project? How do you know?

    Engine : Unity
    Tools :


**Scope (basic) :** How long will it be? How many levels? Big or small levels? What does a "big level" mean? These are basic question about scope, the size and workload for a project.

    Le jeu devrait durer 1h par chapitre environ (mais ouvert à plus avec le pathfinding). Chaque chapitre devrait avoir au 1 ou 2 niveaux. Le niveau seront généralement grands, presque openworld. Plus ou moins guidé/couloir


### Recommended Checklist

**Pillars :** What are the 2-3 most important themes / features of this project?

    Histoire et Lore : c'est un jeu narratif donc HYPER IMPORTANT. Nécessite un vrai travail d'écriture, sert à l'immersion du joueur dans l'univers du jeu.
    
    Pathfinding : impacte principalement le level design. Je dois encore déterminer si je fais un semi-openworld (couloir avec impression de liberté mais guidé vers POI) ou alors un vrai openworld mais doit être justifié et pas ennuyant pour les joueurs (pourrait être réfléchi pour un projet multijoueur)
    
    Environnement Art : je veux un jeu contemplatif, que le joueur puisse prendre le temps d'observer son environnement et soit immergé dans l'univers.

**Experience goals :** How should the player react throughout each level? An emotion, a behavior?

    L'histoire devra être écrite pour ne laisser comprendre au joueur que ce que l'on veut qu'il comprenne. Le POV sera celui du robot de livraison, donc tout ne sera forcément clair dès le début. Le joueur comprendra au fur et à mesure de l'histoire. 
    Attention à ne pas créer de confusion !!!
    
    Idem pour le level design, devra être conçu pour ne montrer que le nécessaire. Façons de faire ça : bloquer en partie la vue de la caméra, événements déclencher 

**Mechanics :** What are the frequent activities / interactions / skills the player will use?\
=> [voir les fonctionnalités de la 1.0](ROADMAP.md)

**Asset list (basic) :** What models, textures, and sounds will you need for each level? What do you have already, and what needs to be found or made?

    Models : Je modéliserai la plupart je pense, histoire d'avoir une cohérence de style graphique dans les assets.

    Textures : Si j'ai le courage, je les ferai moi-même mais je pense que j'utiliserai principalement des textures trouvées en ligne

    Sounds : il faut que je m'entraine sur le sound design mais j'ai bien envie de créer les sons moi même. Idem pour la musique, je pourrais même demander à Sinj, Nox et Flami s'il veulent faire des OST pour le jeu.








<br><br><br>

**Niveaux semi-linéaires :** \
Un point de départ, un point d'arrivée mais **plusieurs chemins possibles** chacun avec des **conséquences** sur la mission (temps de livraison, intégrité du colis, dangers/risques)

**Environnements :**
- Ville sci-fi :
    - quartier résidentiel (immeubles/bidonville)
    - rues commerciales
    - metro ? permettrai de réutiliser/adapter la map métro du FPS
    - 
- Station spaciale ? (dépend de l'histoire, doit être justifié)
