
using System;
// Definición clase PerfilEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class PerfilEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo fotoPerfilUrl
 */
private string fotoPerfilUrl;



/**
 *	Atributo visibilidadPerfil
 */
private NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum visibilidadPerfil;



/**
 *	Atributo visibilidadActividad
 */
private NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum visibilidadActividad;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo juegoFavorito
 */
private string juegoFavorito;



/**
 *	Atributo perfilJuego
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilJuegoEN> perfilJuego;



/**
 *	Atributo juego
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN> juego;



/**
 *	Atributo usuario
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string FotoPerfilUrl {
        get { return fotoPerfilUrl; } set { fotoPerfilUrl = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum VisibilidadPerfil {
        get { return visibilidadPerfil; } set { visibilidadPerfil = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum VisibilidadActividad {
        get { return visibilidadActividad; } set { visibilidadActividad = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string JuegoFavorito {
        get { return juegoFavorito; } set { juegoFavorito = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilJuegoEN> PerfilJuego {
        get { return perfilJuego; } set { perfilJuego = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN> Juego {
        get { return juego; } set { juego = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public PerfilEN()
{
        perfilJuego = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilJuegoEN>();
        juego = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN>();
}



public PerfilEN(int id, string fotoPerfilUrl, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum visibilidadPerfil, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum visibilidadActividad, string descripcion, string juegoFavorito, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilJuegoEN> perfilJuego, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN> juego, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario
                )
{
        this.init (Id, fotoPerfilUrl, visibilidadPerfil, visibilidadActividad, descripcion, juegoFavorito, perfilJuego, juego, usuario);
}


public PerfilEN(PerfilEN perfil)
{
        this.init (perfil.Id, perfil.FotoPerfilUrl, perfil.VisibilidadPerfil, perfil.VisibilidadActividad, perfil.Descripcion, perfil.JuegoFavorito, perfil.PerfilJuego, perfil.Juego, perfil.Usuario);
}

private void init (int id
                   , string fotoPerfilUrl, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum visibilidadPerfil, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum visibilidadActividad, string descripcion, string juegoFavorito, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilJuegoEN> perfilJuego, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN> juego, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario)
{
        this.Id = id;


        this.FotoPerfilUrl = fotoPerfilUrl;

        this.VisibilidadPerfil = visibilidadPerfil;

        this.VisibilidadActividad = visibilidadActividad;

        this.Descripcion = descripcion;

        this.JuegoFavorito = juegoFavorito;

        this.PerfilJuego = perfilJuego;

        this.Juego = juego;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PerfilEN t = obj as PerfilEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
