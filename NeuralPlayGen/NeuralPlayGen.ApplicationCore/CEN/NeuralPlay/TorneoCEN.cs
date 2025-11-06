

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class TorneoCEN
 *
 */
public partial class TorneoCEN
{
private ITorneoRepository _ITorneoRepository;

public TorneoCEN(ITorneoRepository _ITorneoRepository)
{
        this._ITorneoRepository = _ITorneoRepository;
}

public ITorneoRepository get_ITorneoRepository ()
{
        return this._ITorneoRepository;
}

public int New_ (string p_nombre, Nullable<DateTime> p_fechaInicio, string p_reglas, bool p_estado, int p_comunidad)
{
        TorneoEN torneoEN = null;
        int oid;

        //Initialized TorneoEN
        torneoEN = new TorneoEN ();
        torneoEN.Nombre = p_nombre;

        torneoEN.FechaInicio = p_fechaInicio;

        torneoEN.Reglas = p_reglas;

        torneoEN.Estado = p_estado;


        if (p_comunidad != -1) {
                // El argumento p_comunidad -> Property comunidad es oid = false
                // Lista de oids id
                torneoEN.Comunidad = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN ();
                torneoEN.Comunidad.Id = p_comunidad;
        }



        oid = _ITorneoRepository.New_ (torneoEN);
        return oid;
}

public void Modify (int p_Torneo_OID, string p_nombre, Nullable<DateTime> p_fechaInicio, string p_reglas, bool p_estado)
{
        TorneoEN torneoEN = null;

        //Initialized TorneoEN
        torneoEN = new TorneoEN ();
        torneoEN.Id = p_Torneo_OID;
        torneoEN.Nombre = p_nombre;
        torneoEN.FechaInicio = p_fechaInicio;
        torneoEN.Reglas = p_reglas;
        torneoEN.Estado = p_estado;
        //Call to TorneoRepository

        _ITorneoRepository.Modify (torneoEN);
}

public void Destroy (int id
                     )
{
        _ITorneoRepository.Destroy (id);
}

public TorneoEN ReadOID (int id
                         )
{
        TorneoEN torneoEN = null;

        torneoEN = _ITorneoRepository.ReadOID (id);
        return torneoEN;
}

public System.Collections.Generic.IList<TorneoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TorneoEN> list = null;

        list = _ITorneoRepository.ReadAll (first, size);
        return list;
}
}
}
