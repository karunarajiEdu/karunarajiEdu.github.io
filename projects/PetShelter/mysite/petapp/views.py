from django.shortcuts import render, redirect
from django.http import HttpResponse
from django.template import loader
from .models import Pet
from django.core.paginator import Paginator
from .forms import PetForm
from .forms import InterestForm
from django.contrib.auth.decorators import login_required

# Create your views here.


def Home(request):
    template = loader.get_template('petapp/home.html')
    context = {}
    return HttpResponse(template.render(context, request))


def Contact(request):
    form = InterestForm(request.POST or None)

    if form.is_valid():
        form.save()
        return redirect('Contact')

    return render(request, 'petapp/contact.html', {'form': form})


def Pets(request):
    pet_object = Pet.objects.all()
    pet_type = request.GET.get('pet_type')
    if pet_type != '' and pet_type is not None:
        pet_object = pet_object.filter(animal_type__icontains=pet_type)
    paginator = Paginator(pet_object, 5)
    page = request.GET.get('page')
    pet_object = paginator.get_page(page)
    return render(request, 'petapp/pets.html', {'pet_object': pet_object})


def detail(request, pet_id):
    pet = Pet.objects.get(pk=pet_id)
    context = {
        'pet': pet,
    }
    return render(request, 'petapp/detail.html', context)


def interest_form(request):
    form = InterestForm(request.POST or None)

    if form.is_valid():
        form.save()
        return redirect('Pets')

    return render(request, 'petapp/interest-form.html', {'form': form})


@login_required
def create_pet_profile(request):
    form = PetForm(request.POST or None)

    if form.is_valid():
        form.save()
        return redirect('Pets')

    return render(request, 'petapp/pet-form.html', {'form': form})


@login_required
def update_pet(request, id):
    pet = Pet.objects.get(id=id)
    form = PetForm(request.POST or None, instance=pet)

    if form.is_valid():
        form.save()
        return redirect('Pets')

    return render(request, 'petapp/pet-form.html', {'form': form, 'pet': pet})


@login_required
def delete_pet(request, id):
    pet = Pet.objects.get(id=id)

    if request.method == 'POST':
        pet.delete()
        return redirect('Pets')

    return render(request, 'petapp/pet-delete.html', {'pet': pet})
