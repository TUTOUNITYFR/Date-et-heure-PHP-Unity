# Récupération de la date et heure actuelle sur Unity3D via un script PHP

Ce repo permet de récupérer la date et l'heure d'un fuseau horaire sur Unity via un fichier PHP.

Récupérer la date et l'heure via un fichier PHP permet (contrairement à l'utilisation de System.DateTime) de faire référence à la date et à l'heure actuelle sans que le / les joueur(s) ne puissent manuellement changer la date et l'heure.

La récupération via PHP permet donc _d'éviter la triche_.

# Mise en place

Tutoriel vidéo pour la mise en place : lien à venir

**Tutoriel écrit :**

1) Éditer le fuseau horaire se trouvant dans le fichier PHP (par défaut : Europe/Paris).
2) Uploader le fichier PHP sur un serveur (web ou stockage).
3) Dans le script C#, remplacer le contenu de la variable **url** par l'URL du fichier PHP sur le serveur.
4) Adapter le script selon vos besoins.

_Note : si vous n'avez pas de serveur vous pouvez utiliser le lien de mon fichier, soit : https://www.tutounity.fr/upload/currenttime.php_

# Liens

► Vous retrouverez tous les fuseaux horaires (timezones) existants "[ICI](http://php.net/manual/fr/timezones.php).

► Si vous utilisez ce repo GitHub pensez à me créditer dans votre jeu. Ce n'est pas obligatoire mais c'est fortement apprécié.

► Si vous appréciez mon travail et que vous souhaitez me supporter, vous pouvez effectuer une donation récurente ou unique [sur ma page Tipeee](https://fr.tipeee.com/tuto-unity-fr)
