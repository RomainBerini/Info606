/*



██████╗ ███████╗ █████╗ ██████╗ ███╗   ███╗███████╗
██╔══██╗██╔════╝██╔══██╗██╔══██╗████╗ ████║██╔════╝
██████╔╝█████╗  ███████║██║  ██║██╔████╔██║█████╗  
██╔══██╗██╔══╝  ██╔══██║██║  ██║██║╚██╔╝██║██╔══╝  
██║  ██║███████╗██║  ██║██████╔╝██║ ╚═╝ ██║███████╗
╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═════╝ ╚═╝     ╚═╝╚══════╝
                                                   

┌──────────────────────────────────┐
│ Créer par Romain Berini via GAEA │
│                                  │
│    Map.obj                       │
│    ColormapGlobal.png            │
│    ColormapVegetation.png        │
└──────────────────────────────────┘


┌─────────────────────────────────────────┐
│               CONTROLES                 │
│                                         │
├────Fleche───────────────────────────────┤
│    Z = Etendre la fleche                │
│    S = Retracter la fleche              │
│    W = Monter la fleche                 │
│    X = Descendre la fleche              │
│                                         │
├────Crochet──────────────────────────────┤
│    A = Monter le crochet                │
│    Q = Descendre le crochet             │
│    Espace = Lacher l'objet              │
│                                         │
├────Bras─────────────────────────────────┤
│    (Ne pas utiliser le pavé numérique)  │
│                                         │
│    1 = Etendre bras première partie     │
│    2 = Retracter bras première partie   │
│    3 = Etendre bras deuxieme partie     │
│    4 = Retracter bras deuxieme partie   │
│                                         │
├────Mat──────────────────────────────────┤
│    (Ne pas utiliser le pavé numérique)  │
│                                         │
│    5 = Tourner le mat à gauche          │
│    6 = Tourner le mat à droite          │
└─────────────────────────────────────────┘

A savoir :

    La sécurité bloque les déplacements de la grue si les bras ne sont pas rétracté.
    La sécurité bloque l'extention des bras si il sont rétracté afin qu'ils ne s'etendes pas dans le véhicule.
    La sécurité bloque les mouvements de du mat afin que le vehicule ne se mettes pas en danger en cas de charge trop lourde.
    
*/