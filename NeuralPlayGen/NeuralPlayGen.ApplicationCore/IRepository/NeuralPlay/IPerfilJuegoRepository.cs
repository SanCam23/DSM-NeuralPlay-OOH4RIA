
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface IPerfilJuegoRepository
{
void setSessionCP (GenericSessionCP session);

PerfilJuegoEN ReadOIDDefault (int id
                              );

void ModifyDefault (PerfilJuegoEN perfilJuego);

System.Collections.Generic.IList<PerfilJuegoEN> ReadAllDefault (int first, int size);



int New_ (PerfilJuegoEN perfilJuego);

void Modify (PerfilJuegoEN perfilJuego);


void Destroy (int id
              );


PerfilJuegoEN ReadOID (int id
                       );


System.Collections.Generic.IList<PerfilJuegoEN> ReadAll (int first, int size);
}
}
