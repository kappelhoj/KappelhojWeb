<template>
    <a class="container" :href=path>
      <img class="icon" :src="require(`@/assets/${imageUrl}`)">
      <div class="text-container">
        <div>{{topText}}</div>
        <div>{{bottomText}}</div>
      </div>
    </a>
</template>

<script>
export default{
  name: 'SocialLink',
  props:{
    topText:{
      type: String,
      required: true
    },
    bottomText:{
      type: String,
      required: true
    },
    imageUrl:{
      type: String,
      required: true
    },
    path:{
      type: String,
      required: true
    }
  }

}
</script>


<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

  a{
    text-decoration: none;
    font-weight: 600;
    color: var(--main-white-color);
  }

  .container{
    display: flex;
    padding: 1.0em 0.8em;
    align-items: flex-start;
  }

  .text-container{
    display: flex;
    flex-direction: column;
    margin-left: 0.5em;
  }

  .icon{
    width:2em;
    height:2em;
  }
</style>