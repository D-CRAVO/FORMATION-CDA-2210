document.querySelector('#boutonfold').addEventListener('click', e =>
FaireDerouler(e.target,
document.querySelector('#sectiontofold'),
'Afficher le contenu de l\'image',
'Masquer le contenu de l\'image'));

function FaireDerouler(eventelement, foldelement,textWhenUnfold , textWhenFold){
    if (eventelement.dataset.fold == '0'){
        foldelement.classList.add('fold');
        eventelement.dataset.fold = '1';
        eventelement.innerText = textWhenUnfold;
    }  else if (eventelement.dataset.fold == '1'){
        foldelement.classList.remove('fold');
        eventelement.dataset.fold = '0';
        eventelement.innerText = textWhenFold;
    }
}