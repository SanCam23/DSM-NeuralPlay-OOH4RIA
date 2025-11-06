

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class ChatEquipoCEN
 *
 */
public partial class ChatEquipoCEN
{
private IChatEquipoRepository _IChatEquipoRepository;

public ChatEquipoCEN(IChatEquipoRepository _IChatEquipoRepository)
{
        this._IChatEquipoRepository = _IChatEquipoRepository;
}

public IChatEquipoRepository get_IChatEquipoRepository ()
{
        return this._IChatEquipoRepository;
}

public int New_ (System.Collections.Generic.IList<int> p_equipo)
{
        ChatEquipoEN chatEquipoEN = null;
        int oid;

        //Initialized ChatEquipoEN
        chatEquipoEN = new ChatEquipoEN ();

        chatEquipoEN.Equipo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN>();
        if (p_equipo != null) {
                foreach (int item in p_equipo) {
                        NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN en = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN ();
                        en.Id = item;
                        chatEquipoEN.Equipo.Add (en);
                }
        }

        else{
                chatEquipoEN.Equipo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN>();
        }



        oid = _IChatEquipoRepository.New_ (chatEquipoEN);
        return oid;
}

public void Modify (int p_ChatEquipo_OID)
{
        ChatEquipoEN chatEquipoEN = null;

        //Initialized ChatEquipoEN
        chatEquipoEN = new ChatEquipoEN ();
        chatEquipoEN.Id = p_ChatEquipo_OID;
        //Call to ChatEquipoRepository

        _IChatEquipoRepository.Modify (chatEquipoEN);
}

public void Destroy (int id
                     )
{
        _IChatEquipoRepository.Destroy (id);
}

public ChatEquipoEN ReadOID (int id
                             )
{
        ChatEquipoEN chatEquipoEN = null;

        chatEquipoEN = _IChatEquipoRepository.ReadOID (id);
        return chatEquipoEN;
}

public System.Collections.Generic.IList<ChatEquipoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ChatEquipoEN> list = null;

        list = _IChatEquipoRepository.ReadAll (first, size);
        return list;
}
}
}
