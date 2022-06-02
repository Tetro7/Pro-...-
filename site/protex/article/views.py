from django.http import HttpResponse
from django.shortcuts import render

def index(request):
    return HttpResponse('Главная страница')

def cats(request, cat_id):
    return HttpResponse(f'<h1>Категория {cat_id}</h1>')