<template>
  <div class="container">
    <a :href=path>
      <img :src=image>
      {{description}}
    </a>
  </div>
</template>


<script>
import image from "./assets/logo.png"

export default{
  name: 'SocialLink',
  props:{
    description:{
      type: String,
      required: true
    },
    image:{
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
  .container{
    padding: 0.5em 0.5em;
  }
</style>