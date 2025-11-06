
using System;
// Definición clase ChatEquipoEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class ChatEquipoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo equipo
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN> equipo;



/**
 *	Atributo mensajeChat
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MensajeChatEN> mensajeChat;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN> Equipo {
        get { return equipo; } set { equipo = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MensajeChatEN> MensajeChat {
        get { return mensajeChat; } set { mensajeChat = value;  }
}





public ChatEquipoEN()
{
        equipo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN>();
        mensajeChat = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MensajeChatEN>();
}



public ChatEquipoEN(int id, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN> equipo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MensajeChatEN> mensajeChat
                    )
{
        this.init (Id, equipo, mensajeChat);
}


public ChatEquipoEN(ChatEquipoEN chatEquipo)
{
        this.init (chatEquipo.Id, chatEquipo.Equipo, chatEquipo.MensajeChat);
}

private void init (int id
                   , System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN> equipo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MensajeChatEN> mensajeChat)
{
        this.Id = id;


        this.Equipo = equipo;

        this.MensajeChat = mensajeChat;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ChatEquipoEN t = obj as ChatEquipoEN;
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
