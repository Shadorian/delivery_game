# ROADMAP

## **Informations Générales**

**Nom du jeu :** A DETERMINER

**Type de jeu :** Jeu à histoire linéraire en vue 3e personne

**But du jeu :** Livraisons de colis à travers des missions qui feront découvrir la ville

**Nombre de joueurs :** Solo

**Plateforme :** PC mais jouable manette (=> possibilité de portage vers console)

**Inspirations :** Death Stranding (pour le concept)

**Direction Artistique/Univers :** univers sci-fi dystopique, ville/pays gouverné.e par la droite faciste et les corporations

### Deadline (idéale) : Septembre 2027


# Glossaire
### **1. Level Design** : voir le fichier de [level design](LevelDesign.md)
### **2. Story** : voir le fichier de [story](Story.md)

## **Fonctionnalités à implémenter d'ici la version `1.0`**
### **Mouvements :**
- marcher
- courir
- sauter
- s'accroupir
- grimper (petit objet, grand objet, très grand objet)
- pousser/Tirer objet

### **Interactions :**
- récupérer un objet
- presser un bouton (mur droit/incliné)
- ouvrir/regarder le sac

### **Camera**
- camera dynamique = plusieurs positions (orbital, third person aim, 2.5D view, top down)

### **QoL :**
- Carte interactive en 2D/3D holographique potentiellement
- Tutoriel : phase de tuto au début ? apprentissage au fur et à mesure ?

### **Histoire/Lore :**
- PNJs (bulle de texte ? ou modèle 3D ?)
- histoire linéaire sous la perspective du robot

### **Types de missions :**
- Légal : nourriture, colis, médocs, ...
- Illégal : drogue, bombe cachée, organes

## **Tutoriel**
Les méchaniques devraient être apprises seulement quand nécessaire. Evite de surcharger les joueurs d'infos au début. \
Par exemple, le premier niveau introduit les mécaniques de bases


## **Planning**
### Semaine 41 (du 05/10/26 au 11/10/26) :
- Terminer la V1 du système de camera (orbital ? third person aim ? pan/tilt ?)
    - => Temporairement orbital mais changera sûrement pour autre type
    - Regler le problème de cliping à travers les murs
- Finir d'intégrer les mécaniques des mouvements de base (courir, s'accroupir)
    - courir OK : activé avec un toggle (Shift ou Left Stick Pressed)
    - s'accroupir OK : à tester avec gamepad => ~~fonctionne pas encore...~~ c'est bon ça fonctionne, c'était un problème de check ctrlHeld
- Ajuster le feeling de saut. Trop flottant/linéaire pour l'instant
    - => Augmenté la gravité x3 donc 29.4G
    - pourrait être un peu réduit mais doit être entre 2 ou 3 fois la gravité terrestre

### Semaine 42 (du 12/10/26 au 18/10/26) :
- Refléchir au level design de quelques niveaux
- Commencer à écrire l'histoire

### Semaine 43 (du 19/10/26 au 25/10/26) :
- concept art du 1er niveau + modelling/lighting/texturing ???
- Continuer le Level Design sur papier
- Retravailler le modèle 3D du robot sur Blender :
    - Remodelling du haut du corps
    - Rig à refaire

### Semaine 44 (du 26/10/26 au 01/11/26) :
- Blockout/WhiteBox du 1er niveau (tutorial) => seulement si concept art fait
- Commencer à ajouter l'UI :
    - Une scène de Menu principal et de création de partie
    - Ecran de chargement

### Later
- Ajouter les mouvements avancés : grimper, pousser/tirer
- Ajouter interactions avec des objets physicalisé (pousser/tirer)
- Créer les animations des mouvements de base + idle

## Et après ?
### **Si le jeu plait :**
Création d'un jeu multi openworld (MMO ?) dans l'univers du 1er jeu.

**Fonctionnalités :**
- Economy
- Missions
- Crafting
- Base Building / Housing
- Factions / Guilds
- Social System
