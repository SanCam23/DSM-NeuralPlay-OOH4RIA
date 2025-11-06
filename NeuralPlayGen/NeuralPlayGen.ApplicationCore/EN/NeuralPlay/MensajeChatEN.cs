
using System;
// Definición clase MensajeChatEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class MensajeChatEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo contenido
 */
private string contenido;



/**
 *	Atributo fechaEnvio
 */
private Nullable<DateTime> fechaEnvio;



/**
 *	Atributo chatEquipo
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ChatEquipoEN chatEquipo;



/**
 *	Atributo usuario
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Contenido {
        get { return contenido; } set { contenido = value;  }
}



public virtual Nullable<DateTime> FechaEnvio {
        get { return fechaEnvio; } set { fechaEnvio = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ChatEquipoEN ChatEquipo {
        get { return chatEquipo; } set { chatEquipo = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public MensajeChatEN()
{
}



public MensajeChatEN(int id, string contenido, Nullable<DateTime> fechaEnvio, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ChatEquipoEN chatEquipo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario
                     )
{
        this.init (Id, contenido, fechaEnvio, chatEquipo, usuario);
}


public MensajeChatEN(MensajeChatEN mensajeChat)
{
        this.init (mensajeChat.Id, mensajeChat.Contenido, mensajeChat.FechaEnvio, mensajeChat.ChatEquipo, mensajeChat.Usuario);
}

private void init (int id
                   , string contenido, Nullable<DateTime> fechaEnvio, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ChatEquipoEN chatEquipo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario)
{
        this.Id = id;


        this.Contenido = contenido;

        this.FechaEnvio = fechaEnvio;

        this.ChatEquipo = chatEquipo;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MensajeChatEN t = obj as MensajeChatEN;
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
