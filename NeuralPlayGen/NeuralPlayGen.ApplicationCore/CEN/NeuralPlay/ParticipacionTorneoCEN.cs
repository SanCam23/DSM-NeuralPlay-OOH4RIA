

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class ParticipacionTorneoCEN
 *
 */
public partial class ParticipacionTorneoCEN
{
private IParticipacionTorneoRepository _IParticipacionTorneoRepository;

public ParticipacionTorneoCEN(IParticipacionTorneoRepository _IParticipacionTorneoRepository)
{
        this._IParticipacionTorneoRepository = _IParticipacionTorneoRepository;
}

public IParticipacionTorneoRepository get_IParticipacionTorneoRepository ()
{
        return this._IParticipacionTorneoRepository;
}

public int New_ (NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoParticipacionEnum p_estado, Nullable<DateTime> p_fechaAlta, int p_torneo, int p_equipo)
{
        ParticipacionTorneoEN participacionTorneoEN = null;
        int oid;

        //Initialized ParticipacionTorneoEN
        participacionTorneoEN = new ParticipacionTorneoEN ();
        participacionTorneoEN.Estado = p_estado;

        participacionTorneoEN.FechaAlta = p_fechaAlta;


        if (p_torneo != -1) {
                // El argumento p_torneo -> Property torneo es oid = false
                // Lista de oids id
                participacionTorneoEN.Torneo = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN ();
                participacionTorneoEN.Torneo.Id = p_torneo;
        }


        if (p_equipo != -1) {
                // El argumento p_equipo -> Property equipo es oid = false
                // Lista de oids id
                participacionTorneoEN.Equipo = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN ();
                participacionTorneoEN.Equipo.Id = p_equipo;
        }



        oid = _IParticipacionTorneoRepository.New_ (participacionTorneoEN);
        return oid;
}

public void Modify (int p_ParticipacionTorneo_OID, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoParticipacionEnum p_estado, Nullable<DateTime> p_fechaAlta)
{
        ParticipacionTorneoEN participacionTorneoEN = null;

        //Initialized ParticipacionTorneoEN
        participacionTorneoEN = new ParticipacionTorneoEN ();
        participacionTorneoEN.Id = p_ParticipacionTorneo_OID;
        participacionTorneoEN.Estado = p_estado;
        participacionTorneoEN.FechaAlta = p_fechaAlta;
        //Call to ParticipacionTorneoRepository

        _IParticipacionTorneoRepository.Modify (participacionTorneoEN);
}

public void Destroy (int id
                     )
{
        _IParticipacionTorneoRepository.Destroy (id);
}

public ParticipacionTorneoEN ReadOID (int id
                                      )
{
        ParticipacionTorneoEN participacionTorneoEN = null;

        participacionTorneoEN = _IParticipacionTorneoRepository.ReadOID (id);
        return participacionTorneoEN;
}

public System.Collections.Generic.IList<ParticipacionTorneoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ParticipacionTorneoEN> list = null;

        list = _IParticipacionTorneoRepository.ReadAll (first, size);
        return list;
}
}
}
